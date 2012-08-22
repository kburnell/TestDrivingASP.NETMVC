using StructureMap;

namespace TestDrivingMVC.Common.Utility {

    public static class Resolver {

        public static T GetConcreteInstanceOf<T>() {
            return ObjectFactory.GetInstance<T>();
        }

    }
}