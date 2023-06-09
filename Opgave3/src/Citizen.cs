namespace Opgave3
{
    public class Citizen
    {
        private string _name;
        private int _age;
        private string _address;
        private string _MitID;
        private DirectDemocracySystem _system;

        public Citizen(string name, int age, string address, string MitID)
        {
            _name = name;
            _age = age;
            this._address = address;
            this._MitID = MitID;
        }

        public void Register(DirectDemocracySystem system)
        {
            _system = system;
            _system.RegisterCitizen(this);
        }

        public void CastVote(Vote vote)
        {
            _system.VoteOnProposal(vote);
        }

    }
}