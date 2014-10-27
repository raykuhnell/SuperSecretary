using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSecretary.Handlers
{
    public sealed class HandlerManager
    {
        private static readonly Lazy<HandlerManager> _instance = new Lazy<HandlerManager>(() => new HandlerManager());

        public static HandlerManager Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public Dictionary<string, IHandler> Handlers;

        public HandlerManager()
        {
            // Register built in handlers.
            Handlers = new Dictionary<string, IHandler>();

            IHandler handler = new DateCreatedHandler();
            Handlers.Add(handler.Name, handler);

            handler = new DateModifiedHandler();
            Handlers.Add(handler.Name, handler);

            handler = new DateTakenHandler();
            Handlers.Add(handler.Name, handler);

            handler = new FileExtensionHandler();
            Handlers.Add(handler.Name, handler);
        }
    }
}
