const responses = [
    "Tidak diragukan lagi",
    "Ya, pasti",
    "Tentu saja",
    "Mungkin iya, mungkin tidak",
    "Tidak bisa diprediksi sekarang",
    "Coba tanya lagi nanti",
    "Saya tidak yakin",
    "Saya tidak mau menjawab pertanyaan itu",
    "Tidak mungkin",
    "Sangat mungkin",
    "Saya rasa tidak",
    "Perlu konsultasi lebih lanjut",
    "Tidak ada jaminan",
    "Peluangnya kecil",
    "Mungkin saja",
    "Cobalah lagi nanti",
    "Saya tidak bisa memastikan",
    "Anda lebih tahu daripada saya",
    "Lupakan saja",
    "Tidak pernah",
    "Pasti tidak",
    "Saya akan memikirkannya",
    "Pertanyaan yang menarik",
    "Sudah diputuskan",
    "Mungkin besok",
    "Belum ada jawaban yang pasti",
  ];

function getMagicResponse() {
  const randomIndex = Math.floor(Math.random() * responses.length);
  return responses[randomIndex];
}

function handleSubmit(event) {
  event.preventDefault();
  const inputText = document.getElementById("tanya").value;
  const response = getMagicResponse();

  const tanyaanParagraph = document.querySelector(".tanyaan");
  const jawabanParagraph = document.querySelector(".jawaban");
  tanyaanParagraph.textContent = `Pertanyaan: ${inputText}`;
  jawabanParagraph.textContent = `Jawaban: ${response}`;
}

const form = document.querySelector(".form");

form.addEventListener("submit", handleSubmit);
