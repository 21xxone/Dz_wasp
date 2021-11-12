using System;
using System.Collections.Generic;

namespace ConsoleApp15
{
    public interface IStoreItem
    {
        double Price
        {
            get;
            set;
        }
        void DiscountPrice(int percent)
        {
            Price = Price - (Price * (percent / 100));
        }
    }
    public class Disk : IStoreItem
    {
        protected string name;
        protected string genre;
        protected int burnCount;
        public double Price
        {
            get;
            set;
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public Disk(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
        }
        public virtual int DiskSize
        {
            get;
        }
        public virtual void Burn(params string[] values)
        {

        }
        public void DiscountPrice(int percent)
        {
            Price = Price - (Price * (percent / 100));
        }
    }
    public class Audio : Disk
    {
            protected string artist;
            protected string recordingStudio;
            protected int songsNumber;
            public Audio(string artist, string recordingStudio, int songsNumber, string name, string genre) : base(name, genre)
            {
            this.artist = artist;
            this.recordingStudio = recordingStudio;
            this.songsNumber = songsNumber;
            }
            public override int DiskSize
            {
                get
                {
                    return songsNumber * 8;
                }
            }
            public override void Burn(params string[] values)
            {
                artist = values[0];
                recordingStudio = values[1];
                songsNumber = Convert.ToInt32(values[2]);
                name = values[3];
                genre = values[4];
                burnCount++;
            }
            public override string ToString()
            {
                return $"{name}, {genre}, {artist}, {recordingStudio}, {songsNumber}, {burnCount}";
            }
    }
    public class DVD : Disk
    {
            protected string producer;
            protected string filmCompany;
            protected int minutesCount;
            public DVD(string producer, string filmCompany, int minutesCount, string name, string genre) : base(name, genre)
            {
                this.producer = producer;
                this.filmCompany = filmCompany;
                this.minutesCount = minutesCount;
            }
            public override int DiskSize
            {
                get
                {
                    return (minutesCount / 64) * 2;
                }
            }
            public override void Burn(params string[] values)
            {
                producer = values[0];
                filmCompany = values[1];
                minutesCount = Convert.ToInt32(values[2]);
                name = values[3];
                genre = values[4];
                burnCount++;
            }
            public override string ToString()
            {
                return $"{name}, {genre}, {producer}, {filmCompany}, {minutesCount}, {burnCount}";
            }
    }
    public class Store
    {
            protected string storeName;
            protected string address;
            public List<Audio> audios;
            public List<DVD> dvds;
            public Store(string storeName, string address)
            {
                this.storeName = storeName;
                this.address = address;
            }
            public override string ToString()
            {
                return $"{storeName}, {address}, {audios}, {dvds}";
            }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("1", "2");
            Audio audio1 = new Audio("3", "4",5,"6","7");
            Audio audio2 = new Audio("8", "9", 10, "11", "12");
            DVD dvd1 = new DVD("13", "14", 15, "16", "17");
            DVD dvd2 = new DVD("18", "19", 20, "21", "22");
            Console.WriteLine(store);
            audio1.Burn("23", "24", "25", "26","27");
            foreach(var c in store.audios)
            {
                Console.WriteLine($"{c.Name} - {c.DiskSize}");
            }
            foreach (var c in store.dvds)
            {
                Console.WriteLine($"{c.Name} - {c.DiskSize}");
            }
        }
    }
}
