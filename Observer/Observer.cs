using System;

namespace Observer
{
    public class Observer: IObserver
    {
        IObservable _collObs;

        public Observer(IObservable obs)
        {
            _collObs = obs;
            _collObs.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            Number num = (Number)ob;
            num.Sort();
        }

        public void StopObservance()
        {
            _collObs.RemoveObserver(this);
            _collObs = null;
        }
    }
}