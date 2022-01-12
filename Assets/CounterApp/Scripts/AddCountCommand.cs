using FrameworkDesign;
namespace CounterApp
{
    public struct AddCountCommand : ICommand
    {
        /// <summary>
        /// 在Execute中写真正的逻辑
        /// </summary>
        public void Execute() { CounterApp.Get<ICounterModel>().Count.Value++; }
    }
}