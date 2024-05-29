
namespace MatchGame4955511
{
    /// <summary>
    /// <createdate>2024/05/27</createdate>
    
    /// <company>Instituto Nacional Canton Lourdes (INDEL)</company>
    
    ///<lastmodificationdate>2024/05/29</lastmodificationdate>
    
    ///<lastmodificationdescription>  Cambios de los emojis que en los emojis  /// </lastmodificationdescription>
    
    ///<lastmodifierautor>Marcos Vasquez</lastmodifierautor>

    /// </summary>

    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();

            SetUpGame();
        }

        /// <summary> Metodo que permite jugar con los botones  /// </summary>
        private void SetUpGame()
        {
            //Lista que se utiliza para guardar los emojis para luego mostrarlos en los botones
            List<string> animalEmoji = new List<string>()
            {
                "😸","😸",
                "🐤","🐤",
                "🦁","🦁",
                "🐼","🐼",
                "🐧","🐧",
                "🐨","🐨",
                "🐈","🐈",
                "🐒","🐒",
                            };


            Random random = new Random();

            //Se utiliza para recorrer las columnas del grid de manera aleatoria y mostrar un emoji diferente
            foreach (Button view in Grid1.Children)
            {
                int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                view.Text = nextEmoji;

                //El metodo RemoveAt sirve para eliminar un boton con un emoji
                animalEmoji.RemoveAt(index);
            }
        }

       
        Button ultimoButtonClicked;

        //Variable booleana para comparar con un valor falso 
        bool encontrandoMatch = false;

        /// <summary> Metodo permite seleccionar un boton y depende de su estado este cambia la visibilidad  /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Clicked(object sender, EventArgs e)
        {

            Button? button = sender as Button;

            //Compara el encontrandoMatch si el valor es falso
            if (encontrandoMatch == false)
            {

                //Convierta la visibilidad del button en falsa y se convierte invisible el button
                button.IsVisible = false;
                ultimoButtonClicked = button;
                encontrandoMatch = true;

            }

            //Compara si el button es igual a ultimoButtonClicked.Text
            else if (button.Text == ultimoButtonClicked.Text)
            {
                //Si es igual entonces vuelve invisible el button
                button.IsVisible = false;

                //Sigue siendo falso 
                encontrandoMatch = false;
            }

            // Si  el encontrandoMatch si el valor es verdadero
            else
            {
                //Cambia la visibilidad a verdadero
                ultimoButtonClicked.IsVisible = true;

                //Sigue manteniendose en falso
                encontrandoMatch = false;
            }
        }
    }

}
