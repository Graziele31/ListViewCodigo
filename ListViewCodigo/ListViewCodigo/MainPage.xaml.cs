using ListViewCodigo.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewCodigo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        [Obsolete]
        public MainPage()
        {
            InitializeComponent();
            ListView lstview = new ListView();
            lstview.ItemsSource = new List<Time>
            {
                new Time
                {
                     nome = "Flamengo",
                     imagem = "img/flamengo.png",
                     descricao = "O Clube de Regatas do Flamengo" +
                     " é uma agremiação poliesportiva brasileira" +
                     " com sede na cidade do Rio de Janeiro," +
                     " capital do estado de mesmo nome.",
                     tecnico = "Renato Gaúcho",
                     jogadores = new string [] {"Jogador1", "Jogador2",
                         "Jogador3","Jogador4","Jogador5","Jogador6",
                         "Jogador7", "Jogador8", "Jogador9", "Jogador10", "Jogador11" },                     
                },
                new Time
                {
                     nome = "Corinthians ",
                     imagem = "img/corintias.png",
                     descricao = "O Sport Club Corinthians Paulista é um" +
                     " clube multiesportivo brasileiro da cidade de São Paulo," +
                     " capital do estado homônimo. Foi fundado como uma equipe" +
                     " de futebol no dia 1 de setembro de 1910 por um grupo de" +
                     " operários do bairro Bom Retiro.",
                     tecnico = "Sylvio Mendes",
                     jogadores = new string [] {"Jogador1", "Jogador2",
                         "Jogador3","Jogador4","Jogador5","Jogador6",
                         "Jogador7", "Jogador8", "Jogador9", "Jogador10", "Jogador11" },
                },
                new Time
                {
                     nome = "Vasco",
                     imagem = "img/vasco.png",
                     descricao = "Club de Regatas Vasco da Gama é uma entidade" +
                     " sócio-poliesportiva brasileira com sede na cidade do Rio de Janeiro," +
                     " fundada em 21 de agosto de 1898 por um grupo de remadores.",
                     tecnico = "Fernando Diniz",
                     jogadores = new string [] {"Jogador1", "Jogador2",
                         "Jogador3","Jogador4","Jogador5","Jogador6",
                         "Jogador7", "Jogador8", "Jogador9", "Jogador10", "Jogador11" },
                },
                new Time
                {
                     nome = "Palmeiras",
                     imagem = "img/palmeiras.png",
                     descricao = "A Sociedade Esportiva Palmeiras é um clube poliesportivo" +
                     " brasileiro da cidade de São Paulo, capital do estado homônimo." +
                     " Foi fundado em 26 de agosto de 1914 e suas cores, presentes no" +
                     " escudo e bandeira oficial, são o verde e branco.",
                     tecnico = "Abel Ferreira",
                     jogadores = new string [] {"Jogador1", "Jogador2",
                         "Jogador3","Jogador4","Jogador5","Jogador6",
                         "Jogador7", "Jogador8", "Jogador9", "Jogador10", "Jogador11" },
                },
            };
            lstview.ItemTemplate = new DataTemplate(typeof(ImageCell));
            lstview.ItemTemplate.SetBinding (ImageCell.ImageSourceProperty,"imagem");
            lstview.ItemTemplate.SetBinding(ImageCell.TextProperty, "nome");
            lstview.ItemTemplate.SetBinding(ImageCell.DetailProperty, "tecnico");

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            Content = lstview;
        }
    }
}
