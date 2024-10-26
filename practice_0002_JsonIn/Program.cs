using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.CompilerServices;
using CubeTools;
using Numbers;


namespace Numbers
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
        Front,
        Back,
        All
    }
    //class Numbers
    //{



    //}
}



namespace CubeTools
{

    public class AllowedNeighbors
    {
        private int toId;
        private int toName;
        private int toWeight;

    }

    public class Faces
    {
        #region 方向存储

        public List<AllowedNeighbors>[] UpTo;
        public List<AllowedNeighbors>[] DownTo;
        public List<AllowedNeighbors>[] LeftTo;
        public List<AllowedNeighbors>[] RightTo;
        public List<AllowedNeighbors>[] FrontTo;
        public List<AllowedNeighbors>[] BackTo;
        //List<AllowedNeighbors>[][] To;

        #endregion

        public Faces()
        {
            //this.To = new List<AllowedNeighbors>[(int)Direction.All][];
            UpTo = [];
            DownTo = [];
            LeftTo = [];
            RightTo = [];
            FrontTo = [];
            BackTo = [];
        }
        public Faces(string direction, AllowedNeighbors neighbor)
        {
            //this.To[direction].Add(neighbor);
            Type ToFor = GetType();
        }


    }

    public class Cube
    {
        public int id;
        public string name;
        public Cube()
        {

        }
    }
}



namespace _0002_JsonIn
{

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}