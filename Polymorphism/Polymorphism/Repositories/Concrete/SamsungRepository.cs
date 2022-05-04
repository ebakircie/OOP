using System;
using System.Media;
using YZL5155_Polymorphism.Repositories.Interface;

namespace YZL5155_Polymorphism.Repositories.Concrete
{
    public class SamsungRepository : IBaseRepository
    {
        public void CallSound()
        {    
            //  "using" here will help to release created method from heap after it finishes its task without help of Garbage Collector. 
            using (SoundPlayer soundPlayer = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sounds\samsung.wav"))
            {
                soundPlayer.Play();
            }
        }
    }
}
