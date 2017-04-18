namespace RunningCostCalc
{
    class PetrolCar
    {
        const float pricePerGallon = 5.75f;

        public float milesPerGallon;

        public string make;

        public string model;

        public PetrolCar(string make, string model, float mpg)
        {
            this.make = make;
            this.model = model;
            this.milesPerGallon = mpg;
        }

    }
}
