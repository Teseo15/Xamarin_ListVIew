using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {

        public ObservableCollection<ObraList> ObraLista { get; set; } = new ObservableCollection<ObraList>();


        public ListViewGroup()
        {
            InitializeComponent();
            ObraLista.Add(new ObraList("Ciencia Ficción", new[]{ new Obra
            {
                titulo = "El castillo de los Cárpatos",
                author = "Julio Verne",
                portada = "https://www.alianzaeditorial.es/imagenes/libros/grande/9788491817710-el-castillo-de-los-carpatos.jpg"

            },
            new Obra
            {
                titulo = "De la tierra a la luna",
                author = "Julio Verne",
                portada ="https://images.cdn3.buscalibre.com/fit-in/360x360/2c/8b/2c8b4c8414cb84d6c62788cb2e96d90b.jpg"
            },
            new Obra
            {
                titulo = "Fahrenheit 451",
                author = "Ray Bradbury",
                portada = "https://static.cegal.es/imagenes/marcadas/9788417/978841712584.gif"
            },
            new Obra
            {
                titulo = "Graceling",
                author = "Kristin Cashore",
                portada = "https://prodimage.images-bn.com/pimages/9788499181004_p0_v6_s550x406.jpg"
            }}));

            ObraLista.Add(new ObraList("Romanticas", new[]{ new Obra
            {
                titulo = "Maravilloso Desastre",
                author = "Jamie Mcguire",
                portada = "https://imagessl6.casadellibro.com/a/l/t5/76/9788483658376.jpg"

            },
            new Obra
            {
                titulo = "Orgullo y prejuicio",
                author = "Jane Austen",
                portada = "https://covers.alibrate.com/b/59872eaecba2bce50c1f0f62/254d8fa9-0e76-4c81-b2d8-c61933efab16/share"
            },

            new Obra
            {
                titulo = "Más que un verano",
                author = "Victoria Vilchez",
                portada = "https://m.media-amazon.com/images/I/51UqKve5qlL.jpg"
            },
           /* new Obra
            {
                titulo = "Prohibido enamorarse",
                author = "Elle Kennedy"
            }*/}));

            ObraLista.Add(new ObraList("Clásicas", new[]{ 
            new Obra
            {
                titulo = "El conde de Montecristo",
                author = "Alexandre Dumas",
                portada = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRo391c-bjUG3V3DKCU3rhg-8tiFN_0SCSUWA&usqp=CAU"
            },
            new Obra
            {
                titulo = "Don Quijote de la Mancha",
                author = "Miguel de Cervantes",
                portada = "https://mestasediciones.com/wp-content/uploads/2020/06/OM2-Don-Quijote-de-la-mancha-completo.jpg"

            },
            new Obra
            {
                titulo = "Cien años de Soledad",
                author = " Gabriel García Márquez",
                portada = "https://centrocultural.ucab.edu.ve/wp-content/uploads/sites/5/2019/03/Portada-Libro.jpg"
            },
            new Obra
            {
                titulo = "Grandes esperanzas",
                author = "Charles Dickens",
                portada = "https://www.planetadelibros.com/usuaris/libros/fotos/7/m_libros/portada_grandes-esperanzas_charles-dickens_201505260951.jpg"
            }
            }
            ));
            BindingContext = this;
        }
    }

}



