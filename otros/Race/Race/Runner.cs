using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{

    public enum teamType
    {
        A,
        B,
        C,
        D,
        WINNER
    }

    public class Runner
    {
        private int _age;
        private string? _name;
        private double _velocity;
        private int _position;
        public teamType _team;


        public Runner(int age, double velocity, int position, teamType team)
        {
            _age = age;
            _velocity = velocity;
            this._position = position;
            _team = team;
        }

        public Runner()
        {

        }
        
        public int GetPosition()
        {
            return _position;
        }
        
        public int GetAge()
        {
            return _age;
        }

        public string? GetName()
        {
            return _name;
        }

        public double GetVelocity()
        {
            return _velocity;
        }

        public teamType GetTeam()
        {
            if (_team == teamType.A)
                return teamType.A;
            if (_team == teamType.B)
                return teamType.B;
            if (_team == teamType.C)
                return teamType.C;
            else
                return teamType.D;
        }

        public void SetPosition(int position)
        {
            _position = position;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetVelocity(double velocity)
        {
            _velocity = velocity;
        }

        public void SetTeamType(teamType team)
        {
            _team = team;
        }

        public void Move(int x)
        {
            _velocity = x;
        }
    }
}
