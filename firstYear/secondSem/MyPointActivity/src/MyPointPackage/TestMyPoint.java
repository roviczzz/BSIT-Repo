package MyPointPackage;

import javax.swing.*;
import javax.swing.border.TitledBorder;

public class TestMyPoint {
    private JTextArea textArea1;
    private JPanel panel1;
    private JTextPane textPane1;

    {
// GUI initializer generated by IntelliJ IDEA GUI Designer
// >>> IMPORTANT!! <<<
// DO NOT EDIT OR ADD ANY CODE HERE!
        $$$setupUI$$$();
    }

    /**
     * Method generated by IntelliJ IDEA GUI Designer
     * >>> IMPORTANT!! <<<
     * DO NOT edit this method OR call it in your code!
     *
     * @noinspection ALL
     */
    private void $$$setupUI$$$() {
        panel1 = new JPanel();
        panel1.setLayout(new com.jgoodies.forms.layout.FormLayout("fill:d:noGrow,left:4dlu:noGrow,fill:d:grow", "center:d:noGrow"));
        panel1.setBorder(BorderFactory.createTitledBorder(null, "TestMyPoint - Driver", TitledBorder.DEFAULT_JUSTIFICATION, TitledBorder.DEFAULT_POSITION, null, null));
        textArea1 = new JTextArea();
        com.jgoodies.forms.layout.CellConstraints cc = new com.jgoodies.forms.layout.CellConstraints();
        panel1.add(textArea1, cc.xy(1, 1, com.jgoodies.forms.layout.CellConstraints.FILL, com.jgoodies.forms.layout.CellConstraints.FILL));
        textPane1 = new JTextPane();
        panel1.add(textPane1, cc.xy(3, 1, com.jgoodies.forms.layout.CellConstraints.FILL, com.jgoodies.forms.layout.CellConstraints.FILL));
    }

    /**
     * @noinspection ALL
     */
    public JComponent $$$getRootComponent$$$() {
        return panel1;
    }
}