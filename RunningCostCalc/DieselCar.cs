namespace RunningCostCalc
{
    class DieselCar
    {
        const float pricePerGallon = 5.45f;

        public float milesPerGallon;

        public string make;

        public string model;

        public DieselCar(string make, string model, float mpg)
        {
            this.make = make;
            this.model = model;
            this.milesPerGallon = mpg;
        }

    }
}
