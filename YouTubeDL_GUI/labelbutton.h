#ifndef LABELBUTTON_H
#define LABELBUTTON_H

#include <QLabel>
#include <QWidget>
#include <Qt>

class LabelButton : public QLabel
{
    Q_OBJECT
public:
    explicit LabelButton(QWidget *parent = nullptr);

signals:
    void clicked();

protected:
    void mousePressEvent(QMouseEvent* event);

public slots:
};

#endif // LABELBUTTON_H
