using StructureMap;

namespace TestDrivingMVC.Common.Utility {

    public static class Resolver {

        #region << Public Methods >>

        public static T GetConcreteInstanceOf<T>() {
            return ObjectFactory.GetInstance<T>();
        }

        #endregion
    }
}