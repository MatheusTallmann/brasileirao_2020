namespace Domain
{
    public class User
    {
        public bool CBF;
        public bool Torcedor;

        public User(int choice)
        {
            if (choice == 1)
            {
                CBF = true;
            }

            else if (choice == 2)
            {
                Torcedor = true;
            }
            //Padrão de bool = false 
        }
    }
}