#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include "QProcess"

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();

private slots:
    void miniWin();
    void showClearButton();
    void showXE();
    void clearURL();
    void readOutput();
    void fReadOutput();
    void finishDownload();
    void fFinishDownload();
    void updateDL();
    void disableButtons();

    void on_PB_dl_clicked();
    void on_PB_find_clicked();

private:
    Ui::MainWindow *ui;

    // Make window dragable
    void mousePressEvent(QMouseEvent *event);
    void mouseMoveEvent(QMouseEvent *event);
    int m_nMouseClick_X_Coordinate;
    int m_nMouseClick_Y_Coordinate;

    // dl
    QProcess *process;
    QProcess *fProcess;
    void which2dl();
    QString arg2py;
    QString context;
};

#endif // MAINWINDOW_H
