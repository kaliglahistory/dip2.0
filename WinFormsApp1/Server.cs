using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsApp1
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Path = @"C:\Users\user\source\repos\dip\DATA.TXT";
            Random random = new Random();
            int key = random.Next(0, 100000);
            // FileInfo file = new FileInfo(Path);
            string kayin = Convert.ToString(key);
            File.WriteAllText(Path, kayin);
            XmlDocument DOX = new XmlDocument();
            DOX.Load("XMLFile1.xml");
            XmlElement xRoot = DOX.DocumentElement;
            XmlElement kays = DOX.CreateElement("data");
            XmlElement ipElem = DOX.CreateElement("ip");
            XmlText SAD = DOX.CreateTextNode(kayin);
            kays.AppendChild(SAD);
            xRoot.AppendChild(kays);
            DOX.Save("XMLFile1.xml");
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var tcpListener = new TcpListener(IPAddress.Any, 8888);
            var words = new Dictionary<string, string>();
            try
            {
                tcpListener.Start();    // запускаем сервер
                Console.WriteLine("Сервер запущен. Ожидание подключений... ");

                while (true)
                {
                    // получаем подключение в виде TcpClient
                    using var tcpClient = await tcpListener.AcceptTcpClientAsync();
                    // получаем объект NetworkStream для взаимодействия с клиентом
                    var stream = tcpClient.GetStream();
                    // буфер для входящих данных
                    var response = new List<byte>();
                    int bytesRead = 10;
                    while (true)
                    {
                        // считываем данные до конечного символа
                        while ((bytesRead = stream.ReadByte()) != '\n')
                        {
                            // добавляем в буфер
                            response.Add((byte)bytesRead);
                        }
                        var word = Encoding.UTF8.GetString(response.ToArray());

                        // если прислан маркер окончания взаимодействия,
                        // выходим из цикла и завершаем взаимодействие с клиентом
                        if (word == "END") break;

                        Console.WriteLine($"Запрошен перевод слова {word}");
                        // находим слово в словаре и отправляем обратно клиенту
                        if (!words.TryGetValue(word, out var translation)) translation = "не найдено в словаре";
                        // добавляем символ окончания сообщения 
                        translation += '\n';
                        // отправляем перевод слова из словаря
                        await stream.WriteAsync(Encoding.UTF8.GetBytes(translation));
                        response.Clear();
                    }
                }
            }
            finally
            {
                tcpListener.Stop();
            }

        }
    }
}
