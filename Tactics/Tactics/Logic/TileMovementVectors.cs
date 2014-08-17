using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace Tactics.Logic
{
    class TileMovementVectors
    {
        private Dictionary<string, List<Vector2>> upVectors;
        private Dictionary<string, List<Vector2>> downVectors;
        private Dictionary<string, List<Vector2>> rightVectors;
        private Dictionary<string, List<Vector2>> leftVectors;


        public TileMovementVectors()
        {
            upVectors = new Dictionary<string, List<Vector2>>();
            downVectors = new Dictionary<string, List<Vector2>>();
            rightVectors = new Dictionary<string, List<Vector2>>();
            leftVectors = new Dictionary<string, List<Vector2>>();
            fillUp();
            fillDown();
            fillRight();
            fillLeft();
            
        }

        private void fillLeft()
        {
            List<Vector2> tempList = new List<Vector2>();

            tempList.Add(new Vector2(-4, -2));
            tempList.Add(new Vector2(-8, -4));
            tempList.Add(new Vector2(-12, -6));
            tempList.Add(new Vector2(-16, -8));
            tempList.Add(new Vector2(-20, -10));
            tempList.Add(new Vector2(-24, -12));
            tempList.Add(new Vector2(-28, -14));
            tempList.Add(new Vector2(-32, -16));
            tempList.Add(new Vector2(-36, -18));
            
            leftVectors.Add("FFS", tempList);


            List<Vector2> tempList1 = new List<Vector2>();
            
            tempList1.Add(new Vector2(-4, -2));
            tempList1.Add(new Vector2(-8, -4));
            tempList1.Add(new Vector2(-12, -6));
            tempList1.Add(new Vector2(-16, -12));
            tempList1.Add(new Vector2(-20, -18));
            tempList1.Add(new Vector2(-24, -24));
            tempList1.Add(new Vector2(-28, -30));
            tempList1.Add(new Vector2(-32, -32));
            tempList1.Add(new Vector2(-36, -34));

            leftVectors.Add("FFH", tempList);


            List<Vector2> tempList2 = new List<Vector2>();

            tempList2.Add(new Vector2(-4, -2));
            tempList2.Add(new Vector2(-8, -4));
            tempList2.Add(new Vector2(-12, -6));
            tempList2.Add(new Vector2(-16, -8));
            tempList2.Add(new Vector2(-20, -10));
            tempList2.Add(new Vector2(-24, 4));
            tempList2.Add(new Vector2(-28, 2));
            tempList2.Add(new Vector2(-32, 0));
            tempList2.Add(new Vector2(-36, -2));

            leftVectors.Add("FFL", tempList);


            List<Vector2> tempList3 = new List<Vector2>();

            tempList3.Add(new Vector2(-4, -2));
            tempList3.Add(new Vector2(-8, -4));
            tempList3.Add(new Vector2(-12, -6));
            tempList3.Add(new Vector2(-16, -8));
            tempList3.Add(new Vector2(-20, -11));
            tempList3.Add(new Vector2(-24, -14));
            tempList3.Add(new Vector2(-28, -18));
            tempList3.Add(new Vector2(-32, -22));
            tempList3.Add(new Vector2(-36, -26));

            leftVectors.Add("FSU", tempList);


            List<Vector2> tempList4 = new List<Vector2>();

            tempList4.Add(new Vector2(-4, -2));
            tempList4.Add(new Vector2(-8, -4));
            tempList4.Add(new Vector2(-12, -6));
            tempList4.Add(new Vector2(-16, -8));
            tempList4.Add(new Vector2(-20, -10));
            tempList4.Add(new Vector2(-24, -10));
            tempList4.Add(new Vector2(-28, -10));
            tempList4.Add(new Vector2(-32, -10));
            tempList4.Add(new Vector2(-36, -10));

            leftVectors.Add("FSD", tempList);


            List<Vector2> tempList5 = new List<Vector2>();

            tempList5.Add(new Vector2(-4, -4));
            tempList5.Add(new Vector2(-8, -8));
            tempList5.Add(new Vector2(-12, -12));
            tempList5.Add(new Vector2(-16, -16));
            tempList5.Add(new Vector2(-20, -18));
            tempList5.Add(new Vector2(-24, -20));
            tempList5.Add(new Vector2(-28, -22));
            tempList5.Add(new Vector2(-32, -24));
            tempList5.Add(new Vector2(-36, -26));

            leftVectors.Add("SUF", tempList);


            List<Vector2> tempList6 = new List<Vector2>();

            tempList6.Add(new Vector2(-4, 0));
            tempList6.Add(new Vector2(-8, 0));
            tempList6.Add(new Vector2(-12, 0));
            tempList6.Add(new Vector2(-16, 0));
            tempList6.Add(new Vector2(-20, -2));
            tempList6.Add(new Vector2(-24, -4));
            tempList6.Add(new Vector2(-28, -6));
            tempList6.Add(new Vector2(-32, -8));
            tempList6.Add(new Vector2(-36, -10));

            leftVectors.Add("SDF", tempList);
            

            List<Vector2> tempList7 = new List<Vector2>();
            
            tempList7.Add(new Vector2(-4, -4));
            tempList7.Add(new Vector2(-8, -8));
            tempList7.Add(new Vector2(-12, -12));
            tempList7.Add(new Vector2(-16, -16));
            tempList7.Add(new Vector2(-20, -19));
            tempList7.Add(new Vector2(-24, -22));
            tempList7.Add(new Vector2(-28, -26));
            tempList7.Add(new Vector2(-32, -30));
            tempList7.Add(new Vector2(-36, -34));

            leftVectors.Add("SUSU", tempList);


            List<Vector2> tempList8 = new List<Vector2>();

            tempList8.Add(new Vector2(-4, 0));
            tempList8.Add(new Vector2(-8, 0));
            tempList8.Add(new Vector2(-12, 0));
            tempList8.Add(new Vector2(-16, -1));
            tempList8.Add(new Vector2(-20, -1));
            tempList8.Add(new Vector2(-24, -2));
            tempList8.Add(new Vector2(-28, -2));
            tempList8.Add(new Vector2(-32, -2));
            tempList8.Add(new Vector2(-36, -2));

            leftVectors.Add("SDSD", tempList);


            List<Vector2> tempList9 = new List<Vector2>();

            tempList9.Add(new Vector2(-4, 0));
            tempList9.Add(new Vector2(-8, 0));
            tempList9.Add(new Vector2(-12, 0));
            tempList9.Add(new Vector2(-16, 0));
            tempList9.Add(new Vector2(-20, -2));
            tempList9.Add(new Vector2(-24, -6));
            tempList9.Add(new Vector2(-28, -10));
            tempList9.Add(new Vector2(-32, -14));
            tempList9.Add(new Vector2(-36, -18));

            leftVectors.Add("SDSU", tempList);


            List<Vector2> tempList0 = new List<Vector2>();

            tempList0.Add(new Vector2(-4, -4));
            tempList0.Add(new Vector2(-8, -8));
            tempList0.Add(new Vector2(-12, -12));
            tempList0.Add(new Vector2(-16, -16));
            tempList0.Add(new Vector2(-20, -18));
            tempList0.Add(new Vector2(-24, -18));
            tempList0.Add(new Vector2(-28, -18));
            tempList0.Add(new Vector2(-32, -18));
            tempList0.Add(new Vector2(-36, -18));

            leftVectors.Add("SUSD", tempList);
        }

        private void fillDown()
        {
            List<Vector2> tempList = new List<Vector2>();

            tempList.Add(new Vector2(-4, 2));
            tempList.Add(new Vector2(-8, 4));
            tempList.Add(new Vector2(-12, 6));
            tempList.Add(new Vector2(-16, 8));
            tempList.Add(new Vector2(-20, 10));
            tempList.Add(new Vector2(-24, 12));
            tempList.Add(new Vector2(-28, 14));
            tempList.Add(new Vector2(-32, 16));
            tempList.Add(new Vector2(-36, 18));

            downVectors.Add("FFS", tempList);


            List<Vector2> tempList0 = new List<Vector2>();

            tempList0.Add(new Vector2(-4, 2));
            tempList0.Add(new Vector2(-8, 4));
            tempList0.Add(new Vector2(-12, 6));
            tempList0.Add(new Vector2(-16, 8));
            tempList0.Add(new Vector2(-20, 10));
            tempList0.Add(new Vector2(-24, -4));
            tempList0.Add(new Vector2(-28, -2));
            tempList0.Add(new Vector2(-32, 0));
            tempList0.Add(new Vector2(-36, 2));

            downVectors.Add("FFH", tempList);


            List<Vector2> tempList1 = new List<Vector2>();

            tempList1.Add(new Vector2(-4, 2));
            tempList1.Add(new Vector2(-8, 4));
            tempList1.Add(new Vector2(-12, 6));
            tempList1.Add(new Vector2(-16, 12));
            tempList1.Add(new Vector2(-20, 18));
            tempList1.Add(new Vector2(-24, 24));
            tempList1.Add(new Vector2(-28, 30));
            tempList1.Add(new Vector2(-32, 32));
            tempList1.Add(new Vector2(-36, 34));

            downVectors.Add("FFL", tempList);


            List<Vector2> tempList2 = new List<Vector2>();

            tempList2.Add(new Vector2(-4, 2));
            tempList2.Add(new Vector2(-8, 4));
            tempList2.Add(new Vector2(-12, 6));
            tempList2.Add(new Vector2(-16, 8));
            tempList2.Add(new Vector2(-20, 10));
            tempList2.Add(new Vector2(-24, 10));
            tempList2.Add(new Vector2(-28, 10));
            tempList2.Add(new Vector2(-32, 10));
            tempList2.Add(new Vector2(-36, 10));

            downVectors.Add("FSU", tempList);


            List<Vector2> tempList3 = new List<Vector2>();

            tempList3.Add(new Vector2(-4, 2));
            tempList3.Add(new Vector2(-8, 4));
            tempList3.Add(new Vector2(-12, 6));
            tempList3.Add(new Vector2(-16, 8));
            tempList3.Add(new Vector2(-20, 11));
            tempList3.Add(new Vector2(-24, 14));
            tempList3.Add(new Vector2(-28, 18));
            tempList3.Add(new Vector2(-32, 22));
            tempList3.Add(new Vector2(-36, 26));

            downVectors.Add("FSD", tempList);


            List<Vector2> tempList4 = new List<Vector2>();

            tempList4.Add(new Vector2(-4, 0));
            tempList4.Add(new Vector2(-8, 0));
            tempList4.Add(new Vector2(-12, 0));
            tempList4.Add(new Vector2(-16, 0));
            tempList4.Add(new Vector2(-20, 2));
            tempList4.Add(new Vector2(-24, 4));
            tempList4.Add(new Vector2(-28, 6));
            tempList4.Add(new Vector2(-32, 8));
            tempList4.Add(new Vector2(-36, 10));

            downVectors.Add("SUF", tempList);


            List<Vector2> tempList5 = new List<Vector2>();

            tempList5.Add(new Vector2(-4, 4));
            tempList5.Add(new Vector2(-8, 8));
            tempList5.Add(new Vector2(-12, 12));
            tempList5.Add(new Vector2(-16, 16));
            tempList5.Add(new Vector2(-20, 18));
            tempList5.Add(new Vector2(-24, 20));
            tempList5.Add(new Vector2(-28, 22));
            tempList5.Add(new Vector2(-32, 24));
            tempList5.Add(new Vector2(-36, 26));

            downVectors.Add("SDF", tempList);


            List<Vector2> tempList6 = new List<Vector2>();

            tempList6.Add(new Vector2(-4, 0));
            tempList6.Add(new Vector2(-8, 0));
            tempList6.Add(new Vector2(-12, 0));
            tempList6.Add(new Vector2(-16, 1));
            tempList6.Add(new Vector2(-20, 1));
            tempList6.Add(new Vector2(-24, 2));
            tempList6.Add(new Vector2(-28, 2));
            tempList6.Add(new Vector2(-32, 2));
            tempList6.Add(new Vector2(-36, 2));

            downVectors.Add("SUSU", tempList);


            List<Vector2> tempList7 = new List<Vector2>();

            tempList7.Add(new Vector2(-4, 4));
            tempList7.Add(new Vector2(-8, 8));
            tempList7.Add(new Vector2(-12, 12));
            tempList7.Add(new Vector2(-16, 16));
            tempList7.Add(new Vector2(-20, 19));
            tempList7.Add(new Vector2(-24, 22));
            tempList7.Add(new Vector2(-28, 26));
            tempList7.Add(new Vector2(-32, 30));
            tempList7.Add(new Vector2(-36, 34));

            downVectors.Add("SDSD", tempList);


            List<Vector2> tempList8 = new List<Vector2>();

            tempList8.Add(new Vector2(-4, 4));
            tempList8.Add(new Vector2(-8, 8));
            tempList8.Add(new Vector2(-12, 12));
            tempList8.Add(new Vector2(-16, 16));
            tempList8.Add(new Vector2(-20, 18));
            tempList8.Add(new Vector2(-24, 18));
            tempList8.Add(new Vector2(-28, 18));
            tempList8.Add(new Vector2(-32, 18));
            tempList8.Add(new Vector2(-36, 18));

            downVectors.Add("SDSU", tempList);


            List<Vector2> tempList9 = new List<Vector2>();

            tempList9.Add(new Vector2(-4, 0));
            tempList9.Add(new Vector2(-8, 0));
            tempList9.Add(new Vector2(-12, 0));
            tempList9.Add(new Vector2(-16, 0));
            tempList9.Add(new Vector2(-20, 2));
            tempList9.Add(new Vector2(-24, 6));
            tempList9.Add(new Vector2(-28, 10));
            tempList9.Add(new Vector2(-32, 14));
            tempList9.Add(new Vector2(-36, 18));

            downVectors.Add("SUSD", tempList);
        }

        private void fillRight()
        {
            List<Vector2> tempList = new List<Vector2>();

            tempList.Add(new Vector2(4, 2));
            tempList.Add(new Vector2(8, 4));
            tempList.Add(new Vector2(12, 6));
            tempList.Add(new Vector2(16, 8));
            tempList.Add(new Vector2(20, 10));
            tempList.Add(new Vector2(24, 12));
            tempList.Add(new Vector2(28, 14));
            tempList.Add(new Vector2(32, 16));
            tempList.Add(new Vector2(36, 18));

            rightVectors.Add("FFS", tempList);


            List<Vector2> tempList0 = new List<Vector2>();

            tempList0.Add(new Vector2(4, 2));
            tempList0.Add(new Vector2(8, 4));
            tempList0.Add(new Vector2(12, 6));
            tempList0.Add(new Vector2(16, 8));
            tempList0.Add(new Vector2(20, 10));
            tempList0.Add(new Vector2(24, -4));
            tempList0.Add(new Vector2(28, -2));
            tempList0.Add(new Vector2(32, 0));
            tempList0.Add(new Vector2(36, 2));

            rightVectors.Add("FFH", tempList);


            List<Vector2> tempList1 = new List<Vector2>();

            tempList1.Add(new Vector2(4, 2));
            tempList1.Add(new Vector2(8, 4));
            tempList1.Add(new Vector2(12, 6));
            tempList1.Add(new Vector2(16, 12));
            tempList1.Add(new Vector2(20, 18));
            tempList1.Add(new Vector2(24, 24));
            tempList1.Add(new Vector2(28, 30));
            tempList1.Add(new Vector2(32, 32));
            tempList1.Add(new Vector2(36, 34));

            rightVectors.Add("FFL", tempList);


            List<Vector2> tempList2 = new List<Vector2>();

            tempList2.Add(new Vector2(4, 2));
            tempList2.Add(new Vector2(8, 4));
            tempList2.Add(new Vector2(12, 6));
            tempList2.Add(new Vector2(16, 8));
            tempList2.Add(new Vector2(20, 10));
            tempList2.Add(new Vector2(24, 10));
            tempList2.Add(new Vector2(28, 10));
            tempList2.Add(new Vector2(32, 10));
            tempList2.Add(new Vector2(36, 10));

            rightVectors.Add("FSU", tempList);


            List<Vector2> tempList3 = new List<Vector2>();

            tempList3.Add(new Vector2(4, 2));
            tempList3.Add(new Vector2(8, 4));
            tempList3.Add(new Vector2(12, 6));
            tempList3.Add(new Vector2(16, 8));
            tempList3.Add(new Vector2(20, 11));
            tempList3.Add(new Vector2(24, 14));
            tempList3.Add(new Vector2(28, 18));
            tempList3.Add(new Vector2(32, 22));
            tempList3.Add(new Vector2(36, 26));

            rightVectors.Add("FSD", tempList);


            List<Vector2> tempList4 = new List<Vector2>();

            tempList4.Add(new Vector2(4, 0));
            tempList4.Add(new Vector2(8, 0));
            tempList4.Add(new Vector2(12, 0));
            tempList4.Add(new Vector2(16, 0));
            tempList4.Add(new Vector2(20, 2));
            tempList4.Add(new Vector2(24, 4));
            tempList4.Add(new Vector2(28, 6));
            tempList4.Add(new Vector2(32, 8));
            tempList4.Add(new Vector2(36, 10));

            rightVectors.Add("SUF", tempList);


            List<Vector2> tempList5 = new List<Vector2>();

            tempList5.Add(new Vector2(4, 4));
            tempList5.Add(new Vector2(8, 8));
            tempList5.Add(new Vector2(12, 12));
            tempList5.Add(new Vector2(16, 16));
            tempList5.Add(new Vector2(20, 18));
            tempList5.Add(new Vector2(24, 20));
            tempList5.Add(new Vector2(28, 22));
            tempList5.Add(new Vector2(32, 24));
            tempList5.Add(new Vector2(36, 26));

            rightVectors.Add("SDF", tempList);


            List<Vector2> tempList6 = new List<Vector2>();

            tempList6.Add(new Vector2(4, 0));
            tempList6.Add(new Vector2(8, 0));
            tempList6.Add(new Vector2(12, 0));
            tempList6.Add(new Vector2(16, 1));
            tempList6.Add(new Vector2(20, 1));
            tempList6.Add(new Vector2(24, 2));
            tempList6.Add(new Vector2(28, 2));
            tempList6.Add(new Vector2(32, 2));
            tempList6.Add(new Vector2(36, 2));

            rightVectors.Add("SUSU", tempList);


            List<Vector2> tempList7 = new List<Vector2>();

            tempList7.Add(new Vector2(4, 4));
            tempList7.Add(new Vector2(8, 8));
            tempList7.Add(new Vector2(12, 12));
            tempList7.Add(new Vector2(16, 16));
            tempList7.Add(new Vector2(20, 19));
            tempList7.Add(new Vector2(24, 22));
            tempList7.Add(new Vector2(28, 26));
            tempList7.Add(new Vector2(32, 30));
            tempList7.Add(new Vector2(36, 34));

            rightVectors.Add("SDSD", tempList);


            List<Vector2> tempList8 = new List<Vector2>();

            tempList8.Add(new Vector2(4, 4));
            tempList8.Add(new Vector2(8, 8));
            tempList8.Add(new Vector2(12, 12));
            tempList8.Add(new Vector2(16, 16));
            tempList8.Add(new Vector2(20, 18));
            tempList8.Add(new Vector2(24, 18));
            tempList8.Add(new Vector2(28, 18));
            tempList8.Add(new Vector2(32, 18));
            tempList8.Add(new Vector2(36, 18));

            rightVectors.Add("SDSU", tempList);


            List<Vector2> tempList9 = new List<Vector2>();

            tempList9.Add(new Vector2(4, 0));
            tempList9.Add(new Vector2(8, 0));
            tempList9.Add(new Vector2(12, 0));
            tempList9.Add(new Vector2(16, 0));
            tempList9.Add(new Vector2(20, 2));
            tempList9.Add(new Vector2(24, 6));
            tempList9.Add(new Vector2(28, 10));
            tempList9.Add(new Vector2(32, 14));
            tempList9.Add(new Vector2(36, 18));

            rightVectors.Add("SUSD", tempList);
        }

        private void fillUp()
        {
            List<Vector2> tempList = new List<Vector2>();

            tempList.Add(new Vector2(2, -1));
            tempList.Add(new Vector2(4, -2));
            tempList.Add(new Vector2(6, -3));
            tempList.Add(new Vector2(8, -4));
            tempList.Add(new Vector2(10, -5));
            tempList.Add(new Vector2(12, -6));
            tempList.Add(new Vector2(14, -7));
            tempList.Add(new Vector2(-2, 1));
            tempList.Add(new Vector2(0, -0));

            upVectors.Add("FFS", tempList);


            List<Vector2> tempList0 = new List<Vector2>();

            tempList0.Add(new Vector2(4, -2));
            tempList0.Add(new Vector2(8, -4));
            tempList0.Add(new Vector2(12, -6));
            tempList0.Add(new Vector2(16, -12));
            tempList0.Add(new Vector2(20, -18));
            tempList0.Add(new Vector2(24, -24));
            tempList0.Add(new Vector2(28, -30));
            tempList0.Add(new Vector2(32, -32));
            tempList0.Add(new Vector2(36, -34));

            upVectors.Add("FFH", tempList);


            List<Vector2> tempList1 = new List<Vector2>();

            tempList1.Add(new Vector2(4, -2));
            tempList1.Add(new Vector2(8, -4));
            tempList1.Add(new Vector2(12, -6));
            tempList1.Add(new Vector2(16, -8));
            tempList1.Add(new Vector2(20, -10));
            tempList1.Add(new Vector2(24, 4));
            tempList1.Add(new Vector2(28, 2));
            tempList1.Add(new Vector2(32, 0));
            tempList1.Add(new Vector2(36, -2));

            upVectors.Add("FFL", tempList);


            List<Vector2> tempList2 = new List<Vector2>();

            tempList2.Add(new Vector2(4, -2));
            tempList2.Add(new Vector2(8, -4));
            tempList2.Add(new Vector2(12, -6));
            tempList2.Add(new Vector2(16, -8));
            tempList2.Add(new Vector2(20, -11));
            tempList2.Add(new Vector2(24, -14));
            tempList2.Add(new Vector2(28, -18));
            tempList2.Add(new Vector2(32, -22));
            tempList2.Add(new Vector2(36, -26));

            upVectors.Add("FSU", tempList);


            List<Vector2> tempList3 = new List<Vector2>();

            tempList3.Add(new Vector2(4, -2));
            tempList3.Add(new Vector2(8, -4));
            tempList3.Add(new Vector2(12, -6));
            tempList3.Add(new Vector2(16, -8));
            tempList3.Add(new Vector2(20, -10));
            tempList3.Add(new Vector2(24, -10));
            tempList3.Add(new Vector2(28, -10));
            tempList3.Add(new Vector2(32, -10));
            tempList3.Add(new Vector2(36, -10));

            upVectors.Add("FSD", tempList);


            List<Vector2> tempList4 = new List<Vector2>();

            tempList4.Add(new Vector2(4, -4));
            tempList4.Add(new Vector2(8, -8));
            tempList4.Add(new Vector2(12, -12));
            tempList4.Add(new Vector2(16, -16));
            tempList4.Add(new Vector2(20, -18));
            tempList4.Add(new Vector2(24, -20));
            tempList4.Add(new Vector2(28, -22));
            tempList4.Add(new Vector2(32, -24));
            tempList4.Add(new Vector2(36, -26));

            upVectors.Add("SUF", tempList);


            List<Vector2> tempList5 = new List<Vector2>();

            tempList5.Add(new Vector2(4, 0));
            tempList5.Add(new Vector2(8, 0));
            tempList5.Add(new Vector2(12, 0));
            tempList5.Add(new Vector2(16, 0));
            tempList5.Add(new Vector2(20, -2));
            tempList5.Add(new Vector2(24, -4));
            tempList5.Add(new Vector2(28, -6));
            tempList5.Add(new Vector2(32, -8));
            tempList5.Add(new Vector2(36, -10));

            upVectors.Add("SDF", tempList);


            List<Vector2> tempList6 = new List<Vector2>();

            tempList6.Add(new Vector2(4, -4));
            tempList6.Add(new Vector2(8, -8));
            tempList6.Add(new Vector2(12, -12));
            tempList6.Add(new Vector2(16, -16));
            tempList6.Add(new Vector2(20, -19));
            tempList6.Add(new Vector2(24, -22));
            tempList6.Add(new Vector2(28, -26));
            tempList6.Add(new Vector2(32, -30));
            tempList6.Add(new Vector2(36, -34));

            upVectors.Add("SUSU", tempList);


            List<Vector2> tempList7 = new List<Vector2>();

            tempList7.Add(new Vector2(4, 0));
            tempList7.Add(new Vector2(8, 0));
            tempList7.Add(new Vector2(12, 0));
            tempList7.Add(new Vector2(16, -1));
            tempList7.Add(new Vector2(20, -1));
            tempList7.Add(new Vector2(24, -2));
            tempList7.Add(new Vector2(28, -2));
            tempList7.Add(new Vector2(32, -2));
            tempList7.Add(new Vector2(36, -2));

            upVectors.Add("SDSD", tempList);


            List<Vector2> tempList8 = new List<Vector2>();

            tempList8.Add(new Vector2(4, 0));
            tempList8.Add(new Vector2(8, 0));
            tempList8.Add(new Vector2(12, 0));
            tempList8.Add(new Vector2(16, 0));
            tempList8.Add(new Vector2(20, -2));
            tempList8.Add(new Vector2(24, -6));
            tempList8.Add(new Vector2(28, -10));
            tempList8.Add(new Vector2(32, -14));
            tempList8.Add(new Vector2(36, -18));

            upVectors.Add("SDSU", tempList);


            List<Vector2> tempList9 = new List<Vector2>();

            tempList9.Add(new Vector2(4, -4));
            tempList9.Add(new Vector2(8, -8));
            tempList9.Add(new Vector2(12, -12));
            tempList9.Add(new Vector2(16, -16));
            tempList9.Add(new Vector2(20, -18));
            tempList9.Add(new Vector2(24, -18));
            tempList9.Add(new Vector2(28, -18));
            tempList9.Add(new Vector2(32, -18));
            tempList9.Add(new Vector2(36, -18));

            upVectors.Add("SUSD", tempList);
        }


        public List<Vector2> getVectors(int direction, string type)
        {
            if (direction == 0)
            {
                return upVectors[type];
            }
            else if (direction == 1)
            {
                return downVectors[type];
            }
            else if (direction == 2)
            {
                return rightVectors[type];
            }
            else if (direction == 3)
            {
                return leftVectors[type];
            }
            else
            {
                return upVectors[type];
            }
        }

        public Dictionary<string, List<Vector2>> getUpVectors()
        {
            return upVectors;
        }

        public Dictionary<string, List<Vector2>> getDownVectors()
        {
            return downVectors;
        }

        public Dictionary<string, List<Vector2>> getRightVectors()
        {
            return rightVectors;
        }

        public Dictionary<string, List<Vector2>> getLeftVectors()
        {
            return leftVectors;
        }
    }
}
