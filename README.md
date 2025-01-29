<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Учебный проект</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            margin: 20px;
            background-color: #f4f4f4;
            color: #333;
        }
        h1 {
            color: #333;
        }
        h2 {
            color: #555;
        }
        ul {
            list-style-type: square;
            padding-left: 20px;
        }
        img {
            max-width: 100%;
            height: auto;
            display: block;
            margin: 20px 0;
        }
        .content {
            background: white;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }
    </style>
</head>
<body>
    <div class="content">
        <h1>Технологии:</h1>
        <ul>
            <li>C#</li>
            <li>WinForms</li>
            <li>Сторонний Web Api для перевода слов.</li>
            <li>PorterStemmer</li>
        </ul>
        <h2>Учебный проект</h2>
        <p>Учебный проект был создан для создания списков уникальных английских слов из книг и их перевода.</p>
        <h2>Основные функциональные возможности:</h2>
        <ul>
            <li>Загрузка текстового файла в качестве входных данных</li>
            <li>Извлечение уникальных английских слов из текста с использованием библиотеки PorterStemmer</li>
            <li>Перевод извлеченных слов на русский язык с помощью стороннего веб-API (MyMemory)</li>
            <li>Вывод результатов в формате "Оригинальное слово --> Перевод"</li>
        </ul>
        <img src="https://github.com/user-attachments/assets/37554c22-f09a-4b79-af8b-bd0b09dfde2b" alt="Проект">
    </div>
</body>
</html>
