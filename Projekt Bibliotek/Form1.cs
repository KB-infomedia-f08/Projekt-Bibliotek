using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projekt_Bibliotek.Classes;



namespace Projekt_Bibliotek
{
    public partial class Form1 : Form
    {

        private List<Media> mediaList = new List<Media>();
        private object dgvMedia;

        public Form1()
        {
            InitializeComponent();


            // Add example media
            mediaList.Add(new Book("Harry Potter", 3, "J.K. Rowling", 1997));
            mediaList.Add(new Audiobook("The Hobbit", 2, "J.R.R. Tolkien", "Andy Serkis"));
            mediaList.Add(new Newspaper("Daily News", 5, "2026-10-07"));
            mediaList.Add(new Movie("The Matrix", 4, "The Wachowskis", 1999));
            mediaList.Add(new Game("Minecraft", 4, "Mojang", "PC"));


            DisplayMedia();
        }


        private void DisplayMedia()
        {
            dgvMedia.Rows.Clear();


            foreach (Media media in mediaList)
            {
                dgvMedia.Rows.Add(
                    media.Title,
                    media.GetType().Name,
                    media.Copies
                );
            }
        }
    }
}
