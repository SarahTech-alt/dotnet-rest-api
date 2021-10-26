using seeSharpAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace seeSharpAPI.Services
{
    public static class GlassesStore
    {
        static List<Frame> Frames { get; }
        static int nextId = 4;
        static GlassesStore()
        {
            Frames = new List<Frame>
            {
                new Frame {
                    Id = 1,
                Name = "Ray-Ban Clubmaster",
                Color = "Brown / Gold",
                Shape = "Browline"
                },
                new Frame {
                Id = 2,
                Name = "Ottoto Bellona",
                Color = "Pnk / Gold",
                Shape = "Oval"
                },
                new Frame { 
                Id= 3,
                Name = "Oakley Socket 5.5",
                Color = "Gunmetal",
                Shape = "Rectangle"}
            };
        }

        public static List<Frame> GetAll() => Frames;

        public static Frame Get(int id) => Frames.FirstOrDefault(p => p.Id == id);

        public static void Add(Frame frame)
        {
            frame.Id = nextId++;
            Frames.Add(frame);
        }

        public static void Delete(int id)
        {
            var frame = Get(id);
            if (frame is null)
                return;

            Frames.Remove(frame);
        }

        public static void Update(Frame frame)
        {
            var index = Frames.FindIndex(p => p.Id == frame.Id);
            if (index == -1)
                return;

            Frames[index] = frame;
        }
    }
}