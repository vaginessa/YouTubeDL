#include "labelbutton.h"

LabelButton::LabelButton(QWidget *parent) : QLabel(parent)
{

}

void LabelButton::mousePressEvent(QMouseEvent* event){
    emit clicked();
}
