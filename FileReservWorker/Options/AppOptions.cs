﻿using System.ComponentModel.DataAnnotations;

namespace FileReservWorker.Config;

/// <summary>
/// Модель параметров приложения
/// Поддерживаемые OS - Windows, Linux
/// </summary>
public class AppOptions
{
    /// <summary> Путь к секции конфигурации </summary>
    public const string SectionName = "AppOptions";
    
    /// <summary>
    /// Путь к источнику
    /// </summary>
    
    public string SourcePath      { get; set; } = String.Empty;
    
    /// <summary> Путь к дирректории приемнику </summary>
    public string DestinationPath { get; set; } = String.Empty;
    
    /// <summary>
    /// Валидируется с помощью регулярного выражения
    /// Обозночения строк:
    /// 1. Минуты
    /// 2. Часы
    /// 3. Дни месяца
    /// 4. Месяц
    /// 5. День недели
    /// Не поддерживаются литтеральные обозначения - MON, TUE, JAN, DEC и т.д.
    /// </summary>
    [RegularExpression("^([\\*]|([0]*([0-6]|[1-5][0-9])([,][0]*([0-6]|[1-5][0-9]))*([-][0]*([0-6]|[1-5][0-9]))?([,][0]*([0-6]|[1-5][0-9]))*(\\/[\\d]+)?)) " +
                              "([\\*]|([0]*([0-9]|[1][0-9]|[2][0-3])([,][0]*([0-9]|[1][0-9]|[2][0-3]))*([-][0]*([0-9]|[1][0-9]|[2][0-3]))?([,][0]*([0-9]|[1][0-9]|[2][0-3]))*(\\/[\\d]+)?)) " +
                              "([\\*]|([0]*([1-9]|[12][0-9]|[3][01])([,][0]*([1-9]|[12][0-9]|[3][01]))*([-][0]*([1-9]|[12][0-9]|[3][01]))?([,][0]*([1-9]|[12][0-9]|[3][01]))*(\\/[\\d]+)?)) " +
                              "([\\*]|([0]*([1-9]|[1][0-2])([,][0]*([1-9]|[1][0-2]))*([-][0]*([1-9]|[1][0-2]))?([,][0]*([1-9]|[1][0-2]))*(\\/[\\d]+)?)) " +
                              "([\\*]|([0]*([0-7])([,][0]*([0-7]))*([-][0]*([0-7]))?([,][0]*([0-7]))*(\\/[\\d]+)?))$")]
    public string Schedule        { get; set; } = String.Empty;
}