using System;
using System.Media;
using YZL5155_Polymorphism.Repositories.Interface;

namespace YZL5155_Polymorphism.Repositories.Concrete
{
    public class IphoneRepository : IBaseRepository
    {
        public void CallSound()
        {
            using (SoundPlayer soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sounds\iphone.wav"))
            {
                soundPlayer.Play();
            }
        }
    }
}
