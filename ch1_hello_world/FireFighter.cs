namespace ConsoleApplication
{
    public class FireFighter : PublicServant, IPerson
    {
        public FireFighter(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        
        //implement the IPerson interface
        public string Name { get; set; }
        public int Age { get; set; }

        public override void DriveToPlaceOfInterest()
        {
            GetInFiretruck();
            TurnOnSiren();
            FollowDirections();
        }

        private void GetInFiretruck()
        {
        }

        private void TurnOnSiren()
        {
        }

        private void FollowDirections()
        {
        }

    }
}