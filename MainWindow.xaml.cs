using System.Windows;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

namespace ChatBotApp
{
    public partial class MainWindow : Window
    {
        private IChatCompletionService _chatService;
        private ChatHistory _history;
        private Kernel _kernel;

        // Gerekli kütüphaneyi NuGet'ten eklemiş olmalısın: Microsoft.SemanticKernel
        public MainWindow()
        {
            InitializeComponent();

            // Ollama bağlantı ayarları
            var builder = Kernel.CreateBuilder();

            // OpenAI yerine yerel Ollama servisini ekliyoruz
            // Not: Buradaki "llama3" indirdiğin model ismiyle aynı olmalı
            builder.AddOllamaChatCompletion(
                modelId: "llama3",
                endpoint: new Uri("http://localhost:11434")
            );

            _kernel = builder.Build();
            _chatService = _kernel.GetRequiredService<IChatCompletionService>();
            _history = new ChatHistory("Sen Türkçeyi çok iyi konuşan, yardımsever bir C# asistanısın.");
        }
        private async void SendButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserTextBox.Text)) return;

            string userInput = UserTextBox.Text;
            ChatListBox.Items.Add($"Siz: {userInput}");

            _history.AddUserMessage(userInput);
            UserTextBox.Clear();

            try
            {
                var response = await _chatService.GetChatMessageContentAsync(_history);
                ChatListBox.Items.Add($"Bot: {response.Content}");
                _history.AddAssistantMessage(response.Content);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}