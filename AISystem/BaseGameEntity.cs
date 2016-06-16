using System.Diagnostics;

namespace AIPract.AISystem
{
    public class BaseGameEntity
    {
        private static int _nextValidID = 0;

        public int ID { get { return _id; } }

        private int _id;

        public BaseGameEntity() { }

        public BaseGameEntity(int id)
        {
            SetID(id);
        }

        private void SetID(int val)
        {
            Debug.Assert(val >= _nextValidID);
            _id = val;
            _nextValidID = _id + 1;
        }

        public virtual void Update(double deltaTime)
        {

        }

    }
}