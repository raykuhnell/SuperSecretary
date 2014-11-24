using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SuperSecretary.Handlers
{
    public sealed class HandlerManager
    {
        private static volatile HandlerManager _instance;
        private static object syncRoot = new Object();

        public static HandlerManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                            _instance = new HandlerManager();
                    }
                }

                return _instance;
            }
        }

        public Dictionary<string, IHandler> Handlers;

        public HandlerManager()
        {
            // Register built in handlers.
            Handlers = new Dictionary<string, IHandler>();

            IHandler handler;

            handler = new Id3AlbumHandler();
            Handlers.Add(handler.Name, handler);

            handler = new Id3ArtistHandler();
            Handlers.Add(handler.Name, handler);

            handler = new CameraMakerHandler();
            Handlers.Add(handler.Name, handler);

            handler = new CameraModelHandler();
            Handlers.Add(handler.Name, handler);

            handler = new DateCreatedHandler();
            Handlers.Add(handler.Name, handler);

            handler = new DateModifiedHandler();
            Handlers.Add(handler.Name, handler);

            handler = new DateTakenHandler();
            Handlers.Add(handler.Name, handler);

            handler = new FileExtensionHandler();
            Handlers.Add(handler.Name, handler);

            handler = new Id3GenreHandler();
            Handlers.Add(handler.Name, handler);
        }

        public IHandler GetByName(string name)
        {
            IHandler handler = null;
            foreach (var pair in Handlers)
            {
                if (pair.Value.Name == name)
                {
                    handler = pair.Value;
                }
            }
            return handler;
        }

        public void LoadAssembly(string fileName)
        {
            var handlerType = typeof(IHandler);

            Assembly a = Assembly.LoadFile(fileName);

            foreach(Type type in a.GetTypes())
            {
                if (!(type.IsInterface || type.IsInterface) && type.GetInterface(handlerType.FullName) != null)
                {
                    IHandler handler = (IHandler)Activator.CreateInstance(type);
                    Handlers.Add(handler.Name, handler);
                }
            }
        }
    }
}
