using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;
using fitlibrary;
using fitSharp;
using fitnesse;
using FitTests;
using HotelProject.Model;
using Moq;
using Hotel.Interfaces;

namespace FitTests
{
    public class FindFreeRoomTest:ColumnFixture
    {
        String DstartD;
        String DstartM;
        String DstartR;
        String DendD;
        String DendM;
        String DendR;
        String cap;

        /* Paste this in FitNesse test
         !contents -R2 -g -p -f -h
        !define TEST_RUNNER {B:\GitHub\IO\CSharpProject\packages\FitSharp.2.6.0\lib\net452\Runner.exe}
        !define COMMAND_PATTERN {%m -c B:\GitHub\IO\CSharpProject\FitTests\storytest.config.xml %p}
        !|FitTests.FindFreeRoomTest|
        |DstartD|DstartM|DstartR|DendD|DendM|DendR|cap|MyTest?|
        |1|1|2018|2|1|2018|4|0,|
        */
        public string MyTest()
        {
            Reservations res = new Reservations();
            res.init();
            DateTime startD = new DateTime(Int32.Parse(DstartR), Int32.Parse(DstartM), Int32.Parse(DstartD));
            DateTime endD = new DateTime(Int32.Parse(DendR), Int32.Parse(DendM), Int32.Parse(DendD));

            Rooms r = new Rooms();
            r.init();
            int[] result = res.FindFreeRoom(startD, endD, Int32.Parse(cap), r);
            StringBuilder str = new StringBuilder();
            foreach (var item in result)
            {
                str.Append(item + ",");
            }
            return str.ToString();
        }
    }
}
