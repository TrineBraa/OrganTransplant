
namespace OrganTransplant
{
    internal class Bernt
    {
        private string _name = "Bernt";
        private string _bloodtype = "AB";
        private List<string> _kidneysBernt = new List<string>{"Destroyed Right Kidney", "Destroyed Left Kidney"};

        public object ShowOrgans()
        {
            foreach (var Organs in _kidneysBernt)
            {
                Console.WriteLine(Organs);
            }

            return this;
        }

        public void ShowBernt()
        {
            Console.WriteLine($"Patient: {_name}");
            Console.WriteLine($"Bloodtype: {_bloodtype}");
            ShowOrgans();
        }

        public void OperateBernt()
        {
            _kidneysBernt.Remove("Destroyed Right Kidney");
            _kidneysBernt.Add("Kåre's donated kidney");

            Console.WriteLine($"the operation was a success! He will survive!");
            ShowOrgans();
        }





    }

    
}
