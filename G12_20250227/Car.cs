namespace G12_20250227
{
    class Car : Comparable
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }

        public override int CompareTo(object obj, int compareBy)
        {
            if (obj is not Car car)
            {
                throw new Exception("Not car object");
            }
            
            if (compareBy == 0)
            {
                if (Year > car.Year)
                {
                    return 1;
                }

                if (Year < car.Year)
                {
                    return -1;
                }
            }
            
            else if (compareBy == 1)
            {
                for (int i = 0, j = 0; i < Make.Length && j < car.Make.Length; i++, j++)
                {
                    if (Make[i] >= car.Make[j])
                    {
                        if (Make[i] == car.Make[j])
                        {
                            continue;
                        }
                        return 1;
                    }

                    if (Make[i] < car.Make[j])
                    {
                        return -1;
                    }
                }
            }

            else if (compareBy == 2)
            {
                for (int i = 0, j = 0; i < Model.Length && j < car.Model.Length; i++, j++)
                {
                    if (Model[i] >= car.Model[j])
                    {
                        if (Model[i] == car.Model[j])
                        {
                            continue;
                        }
                        return 1;
                    }

                    if (Model[i] < car.Model[j])
                    {
                        return -1;
                    }
                }
            }
 
            else
            {
                throw new Exception("Wrong sort number");
            }
            
            return 0;
        }
    }
}
