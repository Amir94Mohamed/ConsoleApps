using System;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {

        private NewsFeed news = new NewsFeed();


        /// <summary>
        /// This method displays the options for the news feed.
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("-- News Feed --");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "" +
                "Display All Posts", "Ouit"
            };

            bool wantToQuit = false;

            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: wantToQuit = true; break;
                }

            } while (!wantToQuit);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostImage()
        {
            throw new NotImplementedException();
        }

        private void PostMessage()
        {
            throw new NotImplementedException();
        }
    }
}
