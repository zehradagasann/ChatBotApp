🤖 C# Desktop LLM ChatBot
Bu proje, C# ve WPF (Windows Presentation Foundation) kullanılarak geliştirilmiş bir masaüstü yapay zeka sohbet uygulamasıdır. Microsoft'un Semantic Kernel kütüphanesini kullanarak hem bulut tabanlı (OpenAI) hem de yerel (Ollama) dil modelleriyle iletişim kurabilir.

✨ Özellikler
Modern Arayüz: WPF ile tasarlanmış, kullanıcı dostu ve akıcı sohbet ekranı.

Semantic Kernel Altyapısı: Esnek ve güçlü AI orkestrasyonu.

Yerel Model Desteği (Ollama): Veri gizliliği için modelleri tamamen kendi bilgisayarınızda (Llama 3, Phi-3 vb.) çalıştırabilme.

Sohbet Geçmişi: Konuşma bağlamını koruyan asenkron mesajlaşma yapısı.

Hızlı Yanıt: async/await yapısı sayesinde donma yapmayan akıcı kullanıcı deneyimi.

🛠️ Gereksinimler
Visual Studio 2022 (.NET Desktop Development iş yükü yüklü olmalı).

.NET 8.0 SDK

Ollama (Eğer modelleri yerel çalıştırmak istiyorsanız).

🚀 Kurulum
Projeyi Klonlayın:

Bash

git clone https://github.com/zehradagasann/ChatBotApp
NuGet Paketlerini Yükleyin: Aşağıdaki komutu Package Manager Console üzerinden çalıştırın veya NuGet arayüzünden yükleyin:

PowerShell

Install-Package Microsoft.SemanticKernel
Install-Package Microsoft.SemanticKernel.Connectors.Ollama
Ollama Modelini Başlatın: Terminali açın ve kullanmak istediğiniz modeli indirin:

ollama run llama3
Çalıştırın: F5 tuşuna basarak projeyi derleyin ve başlatın.

⚙️ Yapılandırma
MainWindow.xaml.cs içerisinde model ismini ve bağlantı adresini isteğinize göre değiştirebilirsiniz:

C#

builder.AddOllamaChatCompletion(
    modelId: "llama3", // Kullandığınız model adı
    endpoint: new Uri("http://localhost:11434")
);
📝 Lisans
Bu proje eğitim amaçlıdır ve MIT lisansı altında sunulmaktadır.
Zehra Dağaşan
![Uygulama Ekran Görüntüsü](<img width="1181" height="665" alt="image" src="https://github.com/user-attachments/assets/5cb95b0a-065a-4cd1-b425-777196982f4f" />)
