
namespace OrganTransplant
{
    internal class Kaare
    {
        private string _name = "Kåre";
        private string _bloodtype = "AB";
        private List<string> _kidneysKaare = new List<string> { "Right Kidney", "Left Kidney" };


        public object ShowOrgans()
        {
            foreach (var Organs in _kidneysKaare)
            {
                Console.WriteLine(Organs);
            }
            return this;
        }


        public void ShowKaare()
            {
                Console.WriteLine($"Patient: {_name}");
                Console.WriteLine($"Bloodtype: {_bloodtype}");
                ShowOrgans();
            }


        public void OperateKaare()
        {
            _kidneysKaare.Remove("Right Kidney");
            Console.WriteLine("Kåre has donated one of his kidneys to help Bernt!");
            ShowOrgans();
        }


    }

   
}
