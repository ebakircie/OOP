using System;
using System.Media;
using YZL5155_Polymorphism.Repositories.Interface;

namespace YZL5155_Polymorphism.Repositories.Concrete
{
    public class NokiaRepository : IBaseRepository
    {
        public void CallSound()
        {
            using (SoundPlayer soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sounds\nokia.wav"))
            {
                soundPlayer.Play();
            }
        }
    }
}
