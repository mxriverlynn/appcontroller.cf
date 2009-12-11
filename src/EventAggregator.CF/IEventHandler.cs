namespace EventAggregator.CF
{
	public interface IEventHandler<T>
	{
		void Handle(T eventData);
	}
}