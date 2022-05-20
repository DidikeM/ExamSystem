# **ExamSystem**
- C# WinForm
- Katmanlı Mimari(n Layered Mimari)
- Ninject
- Entity Framework

Bu proje winform olarak SOLID KISS DRY tasarım kalıpları kullanılmakta olup database olarak mssql seçilmiştir. Entity Framework ile database ile program arasındaki bağlantı sağlanmıştır.

## Teknik Gereksinimler
Bu proje C# dili ile Visual Studio 2019 kullanılarak geliştirilmiştir. .Net Framework 4.7.2 kullanılmıştır.

## Kullanılan Eklentiler ve Nuget Paketleri
- DevExpress
- Ninject
- Entity Framework

## Programın Basit Yapısı

- Entities katmanı
- DataAccess katmanı
- Business katmanı
- WinFormUI katmanı

### Entities Katmanı
Database nesnelerinin bulunduğu katmandır. Her öğe databasede ki bir tabloya karşılık gelmektedir ve hepsi IEntity den kalıtılmaktadır.

### DataAccess Katmanı
Veri erişim katmanıdır. Generic bir repository kullanarak verileri databaseden çeker.

### Business Katmanı
İş katmanıdır. Verilerin databaseden ne kadarının ne şekilde ve nasıl çekileceğini DataAccess i kullanarak belirleyen katmandır.

### WinFormUI Katmanı
Kullanıcıya görsel içeriklerin gösterildiği katmanıdır. Business Katmanı ile ortaklaşa çalışarak gerekli verileri kullanıcıya gösterir.
