using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DeckOfCards_Serialization
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private Deck RandomDeck(int number)
        {
            Deck myDeck = new Deck(new Card[0]);
            for (int i = 0; i < number; i++)
            {
                myDeck.Add(new Card((Values)random.Next(1, 14), (Suits)random.Next(4)));
            }

            return myDeck;
        }

        private void DealCards(Deck deckToDeal, string title)
        {
            Console.WriteLine(title);
            while (deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
            }

            Console.WriteLine("-----------------");
        }

        private void serializeDeckButton_Click(object sender, EventArgs e)
        {
            Deck deckToWrite = RandomDeck(5);
            using (Stream output = File.Create("Deck1.dat"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(output, deckToWrite);
            }

            DealCards(deckToWrite, "What I just wrote to the file");
        }

        private void readDeckButton_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Deck1.dat"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Deck deckFromFile = (Deck)binaryFormatter.Deserialize(input);
                DealCards(deckFromFile, "What I read from file");
            }
        }

        private void serializeDecksButton_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Deck2.dat"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                for (int i = 0; i < 4; i++)
                {
                    Deck deckToWrite = RandomDeck(random.Next(1, 10));
                    binaryFormatter.Serialize(output, deckToWrite);
                    DealCards(deckToWrite, "Deck #" + (i+1) + " written");
                }
            }
        }

        private void readDecksButton_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Deck2.dat"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                for (int i = 0; i < 4; i++)
                {
                    Deck deckFromFile = (Deck)binaryFormatter.Deserialize(input);
                    DealCards(deckFromFile, "Deck #" + (i+1) + " read");
                }
            }
        }
    }
}
