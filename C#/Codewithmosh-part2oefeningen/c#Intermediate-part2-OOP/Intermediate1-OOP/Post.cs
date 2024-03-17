using System;
using System.Collections.Generic;
using static Intermediate1_OOP.Program;

namespace Intermediate1_OOP
{
    internal partial class Program
    {

        // Excersies working with properties and classes

        public class Post
        {

            public DateTime DateOfCreating { get; set; }
            public int _VoteUP { get; set; }
            public int _VoteDOWN { get; set; }
            public Post()
            {

            }
            public Post(DateTime postSelf)
                : this()
            {

                DateOfCreating = postSelf;

            }

            public void voteS(int vo)
            {
                this._VoteUP = vo;

            }

            public void voteSD(int vod)
            {
                this._VoteDOWN = vod;

            }
        }

    }

}


