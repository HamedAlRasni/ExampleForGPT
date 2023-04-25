using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadaSoft.Pathology
{
    /// <summary>
    /// تمثيل المعلومات الشخصية للمريض
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// الاسم الكامل
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// تاريخ الميلاد
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// الجنس
        /// </summary>
        public string? Gender { get; set; }

        /// <summary>
        /// رقم الهوية أو الرقم الوطني
        /// </summary>
        public string? NationalID { get; set; }

        /// <summary>
        /// العنوان الحالي للمريض
        /// </summary>
        public Address? CurrentAddress { get; set; }

        /// <summary>
        /// العنوان السابق
        /// </summary>
        public Address? PreviousAddress { get; set; }

        /// <summary>
        /// الحالة الزوجية
        /// </summary>
        public string? MaritalStatus { get; set; }

        /// <summary>
        /// الجنسية
        /// </summary>
        public Nationality? Nationality { get; set; }

        /// <summary>
        /// الديانة
        /// </summary>
        public Religion? Religion { get; set; }

        /// <summary>
        /// اللغة الأم
        /// </summary>
        public NativeLanguage? NativeLanguage { get; set; }

        /// <summary>
        /// الوظيفة
        /// </summary>
        public Occupation? Occupation { get; set; }

        /// <summary>
        /// مكان العمل
        /// </summary>
        public Workplace? Workplace { get; set; }

        /// <summary>
        /// المستوى التعليمي
        /// </summary>
        public EducationLevel? EducationLevel { get; set; }

        
        /// <summary>
        /// معلومات الاتصال
        /// </summary>
        public ContactInfo? Contact { get; set; }

        /// <summary>
        /// معلومات التأمين الصحي
        /// </summary>
        public HealthInsuranceInfo? Insurance { get; set; }

        /// <summary>
        /// تاريخ الزيارات السابقة للطبيب
        /// </summary>
        public List<PreviousVisit>? PreviousVisits { get; set; }

        /// <summary>
        /// الحالات الصحية السابقة والحالية للمريض
        /// </summary>
        public List<HealthCondition>? HealthConditions { get; set; }

        /// <summary>
        /// نتائج الفحوصات الطبية السابقة
        /// </summary>
        public List<MedicalTest>? MedicalTests { get; set; }

        /// <summary>
        /// الأدوية والمكملات الغذائية التي يتناولها المريض
        /// </summary>
        public List<Medication>? Medications { get; set; }
   
    }

    /// <summary>
    /// تعريف الـ Class الخاص بالعنوان
    /// </summary>
    public class Address
    {
        /// <summary>
        /// الدولة
        /// </summary>
        public Country? Country { get; set; }

        /// <summary>
        /// المدينة
        /// </summary>
        public City? City { get; set; }

        /// <summary>
        /// الرمز البريدي
        /// </summary>
        public string? PostalCode { get; set; }
    }

    /// <summary>
    /// تعريف الـ Class الخاص بمعلومات الاتصال
    /// </summary>
    public class ContactInfo
    {
        /// <summary>
        /// رقم الهاتف
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// البريد الإلكتروني
        /// </summary>
        public string? Email { get; set; }
    }
    
    /// <summary>
    /// تعريف الـ Class الخاص بمعلومات التأمين الصحي
    /// </summary>
    public class HealthInsuranceInfo
    {
        /// <summary>
        /// اسم الشركة التي توفر التأمين
        /// </summary>
        public CompanyInsurance? CompanyName { get; set; }

        /// <summary>
        /// رقم التأمين
        /// </summary>
        public string? InsuranceNumber { get; set; }
    }

    /// <summary>
    /// تعريف الـ Class الخاص بتاريخ الزيارات السابقة للطبيب
    /// </summary>
    public class PreviousVisit
    {
        /// <summary>
        /// تاريخ الزيارة
        /// </summary>
        public DateTime VisitDate { get; set; }

        /// <summary>
        /// اسم الطبيب
        /// </summary>
        public Doctor? Doctor { get; set; }

        /// <summary>
        /// تشخيص الطبيب
        /// </summary>
        public string? Diagnosis { get; set; }
    }
    
    /// <summary>
    /// تعريف الـ Class الخاص بالحالات الصحية السابقة والحالية للمريض
    /// </summary>
    public class HealthCondition
    {
        ///<summary>
        /// اسم الحالة الصحية
        /// </summary>
        public string? ConditionName { get; set; }

        /// <summary>
        /// تاريخ بدء الحالة الصحية
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// تاريخ انتهاء الحالة الصحية
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// وصف الحالة الصحية
        /// </summary>
        public string? Description { get; set; }
    }

    /// <summary>
    /// تعريف الـ Class الخاص بنتائج الفحوصات الطبية السابقة
    /// </summary>
    public class MedicalTest
    {
        /// <summary>
        /// اسم الفحص الطبي
        /// </summary>
        public string? TestName { get; set; }

        /// <summary>
        /// تاريخ الفحص الطبي
        /// </summary>
        public DateTime TestDate { get; set; }

        /// <summary>
        /// نتيجة الفحص الطبي
        /// </summary>
        public string? TestResult { get; set; }
    }

    /// <summary>
    /// تعريف الـ Class الخاص بالأدوية والمكملات الغذائية التي يتناولها المريض
    /// </summary>
    public class Medication
    {
        /// <summary>
        /// اسم الدواء أو المكمل الغذائي
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// الجرعة الموصوفة
        /// </summary>
        public string? Dosage { get; set; }

        /// <summary>
        /// تاريخ بدء تناول الدواء أو المكمل الغذائي
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// تاريخ انتهاء تناول الدواء أو المكمل الغذائي
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// الغرض من تناول الدواء أو المكمل الغذائي
        /// </summary>
        public string? Purpose { get; set; }
    }

    /// <summary>
    /// تمثيل المعلومات الطبية للمريض
    /// </summary>
    public class MedicalRecord
    {
        /// <summary>
        /// تاريخ الزيارات الطبية السابقة
        /// </summary>
        public List<Visit>? Visits { get; set; }

        /// <summary>
        /// التاريخ الصحي العائلي للمريض
        /// </summary>
        public List<MedicalHistory>? MedicalHistory { get; set; }

        /// <summary>
        /// الحالات الطبية الحالية
        /// </summary>
        public List<MedicalCondition>? CurrentMedicalConditions { get; set; }

        /// <summary>
        /// الأدوية المستخدمة الحالية
        /// </summary>
        public List<Medication>? CurrentMedications { get; set; }

        /// <summary>
        /// التحاليل الطبية
        /// </summary>
        public List<MedicalTest>? MedicalTests { get; set; }

        /// <summary>
        /// الإشعاعات
        /// </summary>
        public List<Radiation>? Radiations { get; set; }

        /// <summary>
        /// العمليات الجراحية
        /// </summary>
        public List<Surgery>? Surgeries { get; set; }
    }

    /// <summary>
    /// تمثيل زيارة طبية سابقة
    /// </summary>
    public class Visit
    {
        /// <summary>
        /// تاريخ الزيارة
        /// </summary>
        public DateTime VisitDate { get; set; }

        /// <summary>
        /// سبب الزيارة
        /// </summary>
        public string? VisitReason { get; set; }
        /// <summary>
        /// الأدوية التي تم تناولها خلال الزيارة
        /// </summary>
        public List<Medication>? Medications { get; set; }

        /// <summary>
        /// التشخيص النهائي
        /// </summary>
        public string? Diagnosis { get; set; }

        /// <summary>
        /// الإجراءات الطبية التي تم إجراؤها خلال الزيارة
        /// </summary>
        //public List<MedicalProcedure?>? MedicalProcedures { get; set; }
    }

    /// <summary>
    /// تمثيل التاريخ الصحي العائلي
    /// </summary>
    public class MedicalHistory
    {
        /// <summary>
        /// العلاقة بين المريض والشخص الذي يعاني من الحالة الصحية
        /// </summary>
        public string? Relationship { get; set; }

        /// <summary>
        /// نوع الحالة الصحية
        /// </summary>
        public string? ConditionType { get; set; }

        /// <summary>
        /// وصف الحالة الصحية
        /// </summary>
        public string? ConditionDescription { get; set; }
    }

    /// <summary>
    /// تمثيل الحالة الطبية الحالية
    /// </summary>
    public class MedicalCondition
    {
        /// <summary>
        /// نوع الحالة الطبية
        /// </summary>
        public string? ConditionType { get; set; }

        /// <summary>
        /// وصف الحالة الطبية
        /// </summary>
        public string? ConditionDescription { get; set; }
    }

    /// <summary>
    /// تمثيل الإشعاع
    /// </summary>
    public class Radiation
    {
        /// <summary>
        /// نوع الإشعاع
        /// </summary>
        public string? RadiationType { get; set; }

        /// <summary>
        /// تاريخ الإشعاع
        /// </summary>
        public DateTime RadiationDate { get; set; }

        /// <summary>
        /// وصف الإشعاع
        /// </summary>
        public string? RadiationDescription { get; set; }
    }

    /// <summary>
    /// تمثيل العملية الجراحية
    /// </summary>
    public class Surgery
    {
        /// <summary>
        /// نوع العملية الجراحية
        /// </summary>
        public string? SurgeryType { get; set; }

        /// <summary>
        /// تاريخ العملية الجراحية
        /// </summary>
        public DateTime SurgeryDate { get; set; }

        /// <summary>
        /// وصف العملية الجراحية
        /// </summary>
        public string? SurgeryDescription { get; set; }
    }
}