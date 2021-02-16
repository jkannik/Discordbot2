/*using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Discord;
using Discord.Commands;
using Discord.WebSocket;


    public class Commands : ModuleBase<SocketCommandContext>
    {

    int[] money = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    
    //-------------------TEST
        [Command("help")]
        public async Task Help()
        {
            var name = Context.Message.Author;
            Console.WriteLine("\n--" + name + " Startet Task help!--");

            money[0]++;
            await ReplyAsync(Convert.ToString(money[0]));

            await ReplyAsync("Folgende Befehle sind zurzeit verfügbar:");



        Console.WriteLine("--" + name + "--hat Task Status erfolgreich help!--");
        }


        [Command("test")]
            public async Task Status()
            {
            var name = Context.Message.Author;
            Console.WriteLine("\n--" + name + " Startet Task Status!--");

            await Context.Client.SetGameAsync("Prefix: ?");

            await Task.CompletedTask;
            Console.WriteLine("--" + name + "--hat Task Status erfolgreich ausgeführt!--");
            }


            //-------------------PING

        [Command("ping")]
        public async Task Ping()
        {
            var name = Context.Message.Author;
            Console.WriteLine("\n--" + name + " Startet Task Ping!--");


            // Creates a Unicode-based emoji based on the Unicode string.
            // This is effectively the same as new Emoji("💕").
            var pEmoji1 = new Emoji("\U0001F17F");
            var pEmoji2 = new Emoji("\U0001F17E");
            var pEmoji3 = new Emoji("\U0001F196");
            
            // Reacts to the message with the Emoji.
            await Context.Message.AddReactionAsync(pEmoji1);
            await Context.Message.AddReactionAsync(pEmoji2);
            await Context.Message.AddReactionAsync(pEmoji3);

            var users1 = Context.Message.Activity;

            await ReplyAsync(name + " Pong " + users1);
            Console.WriteLine("--" + name + "--hat Task Ping erfolgreich ausgeführt!--");
        }



        //-------------------GUESSING

        int guessNumber = 1;
        [Command("guess")]

        public async Task Guess(int number)
        {
            var name = Context.Message.Author;
            Console.WriteLine("\n--" + name + " Startet Task Guess!--");

            String message = Context.Message.Content;
            int messageL = message.Length;
            message = message.Substring(messageL);
            
                   
            Random rnd = new Random();
            guessNumber = rnd.Next(0, 100);
            guessNumber++;

            await ReplyAsync(Convert.ToString(number));

            if (number == guessNumber)
            {
                await ReplyAsync("Du hast die richtige Zahl geraten! (Die Zahl war " + guessNumber + ")");
            }
            else
            {
                await ReplyAsync("Leider Falsch, die richtige Zahl lautet: " + guessNumber + ". " + "" + "\nDeine Zahl war: " + number);

            }
            

            Console.WriteLine("--" + name + "--hat Task Guess erfolgreich ausgeführt!--");
        }


        //-------------------BALANCE
        [Command("balance")]
        public async Task Currency()
        {
            var name = Context.Message.Author;
            Console.WriteLine("\n--" + name + " Startet Task Currency!--");

            var BalanceName = Convert.ToString(name);
            
            var charsToRemove = new string[] { "#"};
            foreach (var c in charsToRemove)
            {
                BalanceName = BalanceName.Replace(c, "_");
            }


            await ReplyAsync(BalanceName + " hat " + "$");
            

            Console.WriteLine("--" + name + "--hat Task Currency erfolgreich ausgeführt!--"+ BalanceName);
        }


            //-------------------ADDMONEY
        [Command("addmoney")]
        public async Task AddMoney()
        {
            var name = Context.Message.Author;
            Console.WriteLine("\n--" + name + " Startet AddMoney Ping!--");
            
            await ReplyAsync("Geld sollte hier eigentlich hinzugefügt werde");
            
            Console.WriteLine("--" + name + "--hat Task AddMoney erfolgreich ausgeführt!--");
        }

}

    */