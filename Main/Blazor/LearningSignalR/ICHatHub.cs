namespace LearningSignalR
{
    public interface ICHatHub
    {
        Task ReceiveMessage(string message);
    }
}
