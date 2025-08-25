# Examination System

## 1️⃣ Project Description
The **Examination System** is a console-based application that allows users to create and take exams for different subjects.  
It supports **two types of exams**:  

- **Practical Exam**: Only MCQ questions; shows correct answers after finishing.  
- **Final Exam**: MCQ and True/False questions; shows questions, answers, and the grade at the end.  

The system ensures proper **input validation**, clean **object-oriented design**, and follows **SOLID principles**.

---

## 2️⃣ Features
- Create **Subjects** with unique IDs and names.  
- Add **Exams** to each subject (Practical or Final).  
- Support for **different question types**:
  - Multiple Choice Questions (MCQ)
  - True/False Questions  
- **Validation** for all user inputs:
  - Integer ranges
  - Non-empty strings
  - Yes/No choices  
- **Automatic grading** for Final Exams.  
- **Display correct answers** for Practical Exams.  
- Easily extendable for new types of questions or exams.  

---

## 3️⃣ Class Structure

### Exams Folder
- **Exam** (abstract): Base class for all exams.
- **FinalExam**: Implements Exam with both MCQ and True/False questions.
- **PracticalExam**: Implements Exam with only MCQ questions.

### Questions Folder
- **Question**: Base class for all question types.
- **MCQQuestion**: Multiple-choice question implementation.
- **TrueFalseQuestion**: True/False question implementation.
- **Answer**: Represents a single answer with ID and text.

### Subjects Folder
- **Subject**: Represents a subject with ID, name, and its exam.

### Validations Folder
- **ValidInt**: Validates integer inputs.
- **ValidString**: Validates string inputs.
- **ValidYesOrNo**: Validates Yes/No inputs.
- **ValidQuestion**: Handles question answering and input validation.
- **ValidAnswers**: Collects and validates answers for MCQ questions.

### Program
- Entry point (`Main`) to create subjects and start exams.


---

## 5️⃣ Sample Run

```text
Please Enter the Subject Id (1 - 100): 1
Please Enter the Subject Name: Mathematics
Please Enter the Type of Exam (1 for Practical | 2 for Final): 2
===== Final Exam Started =====

Creating Question 1
Please enter the question body: What is 2 + 2?
Please enter mark (1-10): 5
Please enter choice 1: 3
Please enter choice 2: 4
Please enter choice 3: 5
Please enter the right answer id: 2
...
===== Exam Finished =====
Question 1 : What is 2 + 2?
Your Answer  => 4
Right Answer => 4
Your Grade is 5 From 5
Time = 02:34
Thank you

