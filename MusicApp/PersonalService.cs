using System;
using System.Collections.Generic;
using System.Text;


namespace MusicApp
{
   public class PersonalService
   {
        public List<Personal> GetPersonals()
        {
            return new List<Personal>()
            {
                new Personal()
                {
                    image = "thattinh.png",
                    songName = "Thất tình",
                    singer = "Trịnh Đình Quang",
                    delButton = "bin.png"
                },
                 new Personal()
                {
                    image = "kemduyen.jpg",
                    songName = "Kém Duyên",
                    singer = "NIT",
                    delButton = "bin.png"
                },
                  new Personal()
                {
                    image = "hntb.jpg",
                    songName = "Hôm Nay Tôi Buồn",
                    singer = "Phùng Khánh Linh",
                    delButton = "bin.png"
                }
            };
        }

        public List<Personal_2> GetPersonal_2s()
        {
            return new List<Personal_2>()
            {
                new Personal_2()
                {
                    image = "necd.jpg",
                    songName = "Người Em Cố Đô",
                    singer = "NUM X Daa",
                    delButton = "bin.png"
                },
                new Personal_2()
                {
                    image = "dladm.jpg",
                    songName = "Đừng Lo Anh Đợi Mà",
                    singer = "Mr Siro",
                    delButton = "bin.png"
                }
            };
        }
   }
}
