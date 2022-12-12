namespace WriterToFile
{
    internal class Program
    {
        //Sukurkite interface’ą IWriteableToFile
        //Jis turės metodą WriteToFile(string fileName)
        // Klasė implementuojanti jį append’ins savo ToString()
        // (overrideinkit, kad išspausdintų objekto properties) į nurodytą failą.
        //Implementuokite visose sukurtose klasėse, tada sukūrę sąrašą visų objektų,
        //iteruokite per visus ir surašykite į failą.
        //P.S. Failo įrašymo funkcionalumas kartosis daugelyje vietų, gal verta pabandyti iškelti ir pernaudoti?
        static void Main(string[] args)
        {
            var timeWriter = new TimeWriter();
            var dayWriter = new DayWriter();

            var writersList = new List<IWriteableToFile>
            { 
                timeWriter,
                dayWriter,
            };

            for(int i = 0; i < writersList.Count; i++)
            {
                writersList[i].WriteToFile($"writer_{i}.txt");
            }
            
        }
    }
}