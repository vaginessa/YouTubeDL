/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 5.10.1
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QCheckBox>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QLabel>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QPlainTextEdit>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QRadioButton>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QWidget>
#include "labelbutton.h"

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralWidget;
    QLabel *LB_logo;
    LabelButton *LB_close;
    LabelButton *LB_mini;
    LabelButton *LB_more;
    LabelButton *LB_update;
    QPlainTextEdit *PTE_url;
    LabelButton *LB_clear;
    QCheckBox *CB_isList;
    QRadioButton *RB_video;
    QRadioButton *RB_Audio;
    QRadioButton *RB_xFormat;
    QPushButton *PB_dl;
    QPushButton *PB_find;
    QPlainTextEdit *PTE_xe;
    QStatusBar *statusBar;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName(QStringLiteral("MainWindow"));
        MainWindow->resize(520, 148);
        QFont font;
        font.setFamily(QString::fromUtf8("\345\276\256\350\273\237\346\255\243\351\273\221\351\253\224"));
        font.setPointSize(12);
        MainWindow->setFont(font);
        MainWindow->setWindowOpacity(0.95);
        MainWindow->setStyleSheet(QLatin1String("background-color: rgb(12, 12, 12);\n"
"color: rgb(255, 255, 255);"));
        centralWidget = new QWidget(MainWindow);
        centralWidget->setObjectName(QStringLiteral("centralWidget"));
        LB_logo = new QLabel(centralWidget);
        LB_logo->setObjectName(QStringLiteral("LB_logo"));
        LB_logo->setGeometry(QRect(9, 9, 191, 41));
        QFont font1;
        font1.setPointSize(20);
        LB_logo->setFont(font1);
        LB_logo->setStyleSheet(QStringLiteral("image: url(:/icons/yt.png);"));
        LB_close = new LabelButton(centralWidget);
        LB_close->setObjectName(QStringLiteral("LB_close"));
        LB_close->setGeometry(QRect(490, 10, 21, 21));
        LB_close->setFont(font1);
        LB_close->setStyleSheet(QStringLiteral("image: url(:/icons/close.png);"));
        LB_mini = new LabelButton(centralWidget);
        LB_mini->setObjectName(QStringLiteral("LB_mini"));
        LB_mini->setGeometry(QRect(460, 10, 21, 21));
        LB_mini->setFont(font1);
        LB_mini->setStyleSheet(QStringLiteral("image: url(:/icons/mini.png);"));
        LB_more = new LabelButton(centralWidget);
        LB_more->setObjectName(QStringLiteral("LB_more"));
        LB_more->setGeometry(QRect(430, 10, 21, 21));
        LB_more->setFont(font1);
        LB_more->setStyleSheet(QStringLiteral("image: url(:/icons/more.png);"));
        LB_update = new LabelButton(centralWidget);
        LB_update->setObjectName(QStringLiteral("LB_update"));
        LB_update->setGeometry(QRect(400, 10, 21, 21));
        LB_update->setFont(font1);
        LB_update->setStyleSheet(QStringLiteral("image: url(:/icons/update.png);"));
        PTE_url = new QPlainTextEdit(centralWidget);
        PTE_url->setObjectName(QStringLiteral("PTE_url"));
        PTE_url->setGeometry(QRect(10, 60, 501, 31));
        QFont font2;
        font2.setFamily(QString::fromUtf8("\345\276\256\350\273\237\346\255\243\351\273\221\351\253\224"));
        font2.setPointSize(10);
        PTE_url->setFont(font2);
        PTE_url->setStyleSheet(QLatin1String("background-color: rgb(28,28,28);\n"
"color: rgb(230, 225, 250);"));
        LB_clear = new LabelButton(centralWidget);
        LB_clear->setObjectName(QStringLiteral("LB_clear"));
        LB_clear->setGeometry(QRect(486, 65, 21, 21));
        LB_clear->setFont(font1);
        LB_clear->setStyleSheet(QLatin1String("background-color: rgb(28,28,28);\n"
"image: url(:/icons/clear.png);"));
        CB_isList = new QCheckBox(centralWidget);
        CB_isList->setObjectName(QStringLiteral("CB_isList"));
        CB_isList->setGeometry(QRect(10, 100, 51, 18));
        CB_isList->setFont(font);
        CB_isList->setStyleSheet(QStringLiteral("color: rgb(255, 250, 250);"));
        RB_video = new QRadioButton(centralWidget);
        RB_video->setObjectName(QStringLiteral("RB_video"));
        RB_video->setGeometry(QRect(70, 100, 71, 18));
        RB_video->setFont(font);
        RB_video->setStyleSheet(QStringLiteral("color: rgb(255, 250, 250);"));
        RB_video->setChecked(true);
        RB_Audio = new QRadioButton(centralWidget);
        RB_Audio->setObjectName(QStringLiteral("RB_Audio"));
        RB_Audio->setGeometry(QRect(150, 100, 71, 18));
        RB_Audio->setFont(font);
        RB_Audio->setStyleSheet(QStringLiteral("color: rgb(255, 250, 250);"));
        RB_xFormat = new QRadioButton(centralWidget);
        RB_xFormat->setObjectName(QStringLiteral("RB_xFormat"));
        RB_xFormat->setGeometry(QRect(230, 100, 101, 18));
        RB_xFormat->setFont(font);
        RB_xFormat->setStyleSheet(QStringLiteral("color: rgb(255, 250, 250);"));
        PB_dl = new QPushButton(centralWidget);
        PB_dl->setObjectName(QStringLiteral("PB_dl"));
        PB_dl->setGeometry(QRect(410, 100, 101, 20));
        PB_dl->setFont(font);
        PB_dl->setStyleSheet(QStringLiteral("color: rgb(255, 0, 0);"));
        PB_dl->setFlat(true);
        PB_find = new QPushButton(centralWidget);
        PB_find->setObjectName(QStringLiteral("PB_find"));
        PB_find->setGeometry(QRect(350, 100, 51, 20));
        PB_find->setFont(font);
        PB_find->setStyleSheet(QStringLiteral("color: rgb(0, 85, 127);"));
        PB_find->setFlat(true);
        PTE_xe = new QPlainTextEdit(centralWidget);
        PTE_xe->setObjectName(QStringLiteral("PTE_xe"));
        PTE_xe->setGeometry(QRect(230, 95, 111, 31));
        PTE_xe->setFont(font2);
        PTE_xe->setStyleSheet(QLatin1String("background-color: rgb(28,28,28);\n"
"color: rgb(230, 225, 250);"));
        MainWindow->setCentralWidget(centralWidget);
        statusBar = new QStatusBar(MainWindow);
        statusBar->setObjectName(QStringLiteral("statusBar"));
        MainWindow->setStatusBar(statusBar);

        retranslateUi(MainWindow);

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QApplication::translate("MainWindow", "YouTubeDL", nullptr));
        LB_logo->setText(QString());
        LB_close->setText(QString());
        LB_mini->setText(QString());
        LB_more->setText(QString());
        LB_update->setText(QString());
        LB_clear->setText(QString());
        CB_isList->setText(QApplication::translate("MainWindow", "List", nullptr));
        RB_video->setText(QApplication::translate("MainWindow", "Video", nullptr));
        RB_Audio->setText(QApplication::translate("MainWindow", "Audio", nullptr));
        RB_xFormat->setText(QApplication::translate("MainWindow", "X Format", nullptr));
        PB_dl->setText(QApplication::translate("MainWindow", "Download", nullptr));
        PB_find->setText(QApplication::translate("MainWindow", "Find", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
