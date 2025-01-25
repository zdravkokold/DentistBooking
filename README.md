# **Система за управление на часове при зъболекар**

## **1. Описание на проекта**
Системата представлява Web приложение, което улеснява управлението на графика и записванията на пациенти в зъболекарска клиника. Основната цел е да се автоматизира процесът на резервиране на часове, управление на пациенти и генериране на отчети.

---

## **2. Цели на проекта**
- Автоматизация на процеса по управление на графика.
- Подобряване на точността и ефективността при резервирането на часове.
- Предоставяне на ясна история на записванията за всеки пациент.
- Лесен достъп до информация за наличностите на стоматолозите.

---

## **3. Основни функционалности (в процес на разработка)**
### **Управление на пациенти**
- Добавяне, редактиране и изтриване на информация за пациенти (име, контакти, здравен статус).
- Преглед на съществуващи пациенти.

### **Резервиране на часове**
- Пациентите могат да избират дата и час за консултация или лечение.
- Автоматична проверка за конфликти при записвания.

### **История на записванията**
- Проследяване на всички записвания с информация за лечение, дата и час.
- Преглед на записванията по периоди (седмица, месец и т.н.).

### **Управление на графика на стоматолозите**
- Планиране на работното време на стоматолозите.
- Проследяване на наличностите и заетостта.

### **Генериране на справки**
- Отчети за записвания по пациенти и периоди.
- Справки за заетостта на стоматолозите и използваните часове.

---

## **4. Технологии**
- **Език за програмиране:** C#.
- **Инструмент за разработка:** Visual Studio.
- **База данни:** Microsoft SQL Server.
- **ORM:** Entity Framework Core (Code-First Подход).

---

## **5. Архитектура**
### **Слой на данните**
Съдържа следните модели за базата данни:
- **Patient:** Данни за пациентите.
- **Dentist:** Данни за стоматолозите.
- **Appointment:** Информация за записванията.
- **User:** За управление на достъпа.

### **Бизнес логика**
Съдържа services за управление на данните:
- `PatientService`: Управление на пациенти.
- `AppointmentService`: Управление на записвания и графици.
- `DentistService`: Управление на графика на стоматолозите.

---

## **6. Кратко ръководство за потребителя (след като бъде завършена разработката)**
### **Вход в системата**
1. Стартирайте приложението.
2. Въведете потребителско име и парола.
3. Натиснете бутона „Вход“.

### **Добавяне на пациент**
1. Изберете меню „Управление на пациенти“.
2. Натиснете бутона „Добави пациент“.
3. Попълнете данните за пациента и натиснете „Запази“.

### **Резервиране на час**
1. Изберете пациент от списъка.
2. Изберете дата и час за записване.
3. Потвърдете запазването.

### **Преглед на график**
1. Изберете меню „График“.
2. Прегледайте наличностите на стоматолозите по период.

### **Генериране на отчет**
1. Изберете меню „Справки“.
2. Въведете критерии за отчета (период, стоматолог и др.).
3. Натиснете „Генерирай“.

---

## **7. Системни изисквания**
- Операционна система: Windows 10 или по-нова.
- .NET Framework 4.7.2 или .NET Core Runtime.
- Microsoft SQL Server 2019 или по-нова.
