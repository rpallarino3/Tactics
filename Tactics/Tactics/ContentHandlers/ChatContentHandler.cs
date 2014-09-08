using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace Tactics.ContentHandlers
{
    class ChatContentHandler
    {
        private ContentManager content;

        private List<Texture2D> chatBoxes;
        private List<Texture2D> optionBoxes;

        private Texture2D chatHighlight;

        private SpriteFont chatBoxFont;

        public ChatContentHandler(ContentManager content)
        {
            this.content = content;
            chatBoxes = new List<Texture2D>();
            optionBoxes = new List<Texture2D>();
            loadContent();
        }

        private void loadContent()
        {
            chatBoxFont = content.Load<SpriteFont>("Fonts/TestFont");
            chatHighlight = content.Load<Texture2D>("Images/ChatWindows/optionhighlight");

            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by50"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by60"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by70"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by80"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by90"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by100"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by110"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by120"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by130"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by140"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by150"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by160"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by170"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by180"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by190"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/25by200"));


            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by50"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by60"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by70"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by80"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by90"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by100"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by110"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by120"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by130"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by140"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by150"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by160"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by170"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by180"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by190"));
            chatBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/50by200"));

            optionBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/1option"));
            optionBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/2option"));
            optionBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/3option"));
            optionBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/4option"));
            optionBoxes.Add(content.Load<Texture2D>("Images/ChatWindows/5option"));
        }

        public SpriteFont getChatBoxFont()
        {
            return chatBoxFont;
        }

        public List<Texture2D> getChatBoxes()
        {
            return chatBoxes;
        }

        public List<Texture2D> getOptionBoxes()
        {
            return optionBoxes;
        }

        public Texture2D getChatBox(int index)
        {
            return chatBoxes[index];
        }

        public Texture2D getOptionBox(int index)
        {
            return optionBoxes[index];
        }
    }
}
