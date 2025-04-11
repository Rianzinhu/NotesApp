namespace NotesApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string nome = "";

        public MainPage()
        {
            InitializeComponent();
        }


        private void Oibtn_Clicked(object sender, EventArgs e)
        {
            //1- Elemento para digitar o texto/Nome
            //2- Ler o textp digitado e alimentar uma variavel
            //3- Transferir a variavel para a etique / Label


            //OlaLabel
            //MeuNomeEntry
            //OiButton

            nome = MeuNomeEntry.Text;
            OlaLabel.Text = $"Olá, {nome}!";

            //1- 
            //2- string nome = 
            //3- OlaLabel Text = nome
        }
    }

}
