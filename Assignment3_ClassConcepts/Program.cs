

using System;

namespace ConceptOfClassess
{

    public class MusicAlbum
    {
        public string AlbumName { get; set; }
        public string ArtistName { get; set; }
        public string Genre { get; set; }
        public int NumberOfTracks { get; set; }

        // Method to display information about the Music Album
        public void MusicInfo()
        {
            Console.WriteLine("Music Album");
            Console.WriteLine($"1. Album Name is {AlbumName}");
            Console.WriteLine($"2.  Artist Name is {ArtistName}");
            Console.WriteLine($"3.  Genre is {Genre}");

            if (NumberOfTracks > 1)
            {
                Console.WriteLine($"4.  Number of Tracks are {NumberOfTracks} \n\n");
            }
            else
            {
                Console.WriteLine($"4. Number of track is {NumberOfTracks}");
            }
        }
    }

    public class HomeAppliance
    {
        public string ApplianceType { get; set; } // Microwave, AC, Washing machine, Refrigerator
        public string ApplianceBrand { get; set; } //LG, Nexus, Samsung
        public double ApplianceCapacity { get; set; } //5, 7.5kg/hp
        public string ApplianceColor { get; set; }

        public void ApplianceInfo()
        {
            Console.WriteLine("Home Appliance");
            Console.WriteLine($"1. This is a {ApplianceType}");
            Console.WriteLine($"2.  The brand is {ApplianceBrand}");
            Console.WriteLine($"3.  The {ApplianceType} has {ApplianceCapacity}kg capacity");
            Console.WriteLine($"4.  The color of the {ApplianceType} is {ApplianceColor} \n");
            // Console.WriteLine($"HomeAppliance: Appliance Type = {ApplianceType}, Appliance Brand = {ApplianceBrand}, Capacity/Size = {ApplianceCapacity}, Color = {ApplianceColor}");
        }

    }

    public class HeadGear
    {
        public string Style { get; set; } //golf cap, fedora etc,
        public string Brand { get; set; }
        public string Size { get; set; } //small, medium, large/big
        public string Color { get; set; }

        public void HeadGearInfo()
        {
            Console.WriteLine("Head Gear");
            Console.WriteLine($"1. The choice of fashion is {Style}");
            Console.WriteLine($"2. Your brand is {Brand}");
            Console.WriteLine($"3. The size of the  {Style}");
            Console.WriteLine($"4. The color of the {Style} is {Color} \n");
            // Console.WriteLine($"Hat: Style = {Style}, Brand = {Brand}, Size = {Size}, Color = {Color}");
        }

    }


    public class Furniture
    {
        public string FurnitureType { get; set; } //Table, Chair, Shelve, Rack
        public string Material { get; set; } //Wooden, Metal or Plastic
        public string Color { get; set; }
        public bool HasArmRest { get; set; }
        public bool Foldable { get; set; }

        public void FurnitureInfo()
        {
            Console.WriteLine("Furniture");
            Console.WriteLine($"1. Furniture type is {FurnitureType}");
            Console.WriteLine($"2. It is a {Material} material");
            Console.WriteLine($"3. The color of the {FurnitureType} is {Color}");
            if (HasArmRest)
            {
                Console.WriteLine($"4. HasArmRest: Yes");
            }
            else
            {
                Console.WriteLine($"4. HasArmRest: No");
            }

            if (Foldable)
            {
                Console.WriteLine($"5. Foldable: Yes");
            }
            else
            {
                Console.WriteLine($"5. Foldable: No");
            }
            Console.WriteLine("\n");
            // Console.WriteLine($"Furniture: Material = {Material}, Color = {Color}, Arm rest = {HasArmRest}");
        }
    }

    // class of Book
    public class Book
    {
        public string Title { get; set; }
        public string Authur { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }
        public string Edition { get; set; }

        public void BookInfo()
        {
            Console.WriteLine("Book");
            Console.WriteLine($"1. The title of the book is {Title}");
            Console.WriteLine($"2. The authur of the book is {Authur}");
            Console.WriteLine($"3. Your choice of genre is {Genre}");
            Console.WriteLine($"4. The book has {Pages} pages");
            Console.WriteLine($"5, This is the {Edition} edition of the book \n");

            // Console.WriteLine($"Book: Title of Book = {Title}, Authur = {Authur}, Genre = {Genre}, Pages of Book = {Pages}, Book Edition = {Edition}");
        }



        public class Program
        {
            static void Main(string[] args)
            {
                // Creating an instance of the Music Album and other classes
                // Property stores data
                MusicAlbum musicAlbum = new MusicAlbum();
                {
                    musicAlbum.AlbumName = "Adedamola";
                    musicAlbum.ArtistName = "FireboyDML";
                    musicAlbum.Genre = "AfroBeats";
                    musicAlbum.NumberOfTracks = 1;

                }
                musicAlbum.MusicInfo();

                HomeAppliance homeAppliance = new HomeAppliance();
                {
                    homeAppliance.ApplianceType = "Washing Machine";
                    homeAppliance.ApplianceBrand = "Nexus";
                    homeAppliance.ApplianceCapacity = 15;
                    homeAppliance.ApplianceColor = "White";

                }
                homeAppliance.ApplianceInfo();

                HeadGear headGear = new HeadGear();
                {
                    headGear.Style = "Hat";
                    headGear.Brand = "Nike";
                    headGear.Size = "Medium";
                    headGear.Color = "Navy Blue";

                }
                headGear.HeadGearInfo();

                Furniture furniture = new Furniture();
                {
                    furniture.FurnitureType = "Chair";
                    furniture.Material = "Wooden";
                    furniture.Color = "Black";
                    furniture.HasArmRest = true;
                    furniture.Foldable = false;

                }
                furniture.FurnitureInfo();

                Book book = new Book();
                {
                    book.Title = "My Watch";
                    book.Authur = "Olusegun Obasanjo";
                    book.Genre = "Non-Fiction (History/Politics/Auto Biography)";
                    book.Pages = 650;
                    book.Edition = "First";

                }
                book.BookInfo();
            }
        }
    }
}