# 操作地址

EEPROM通过IIC进行操作，IIC操作是需要在Start后发送地址信息，地址信息由8 个bit表示，其中高四位是固定的1010，第四位的高三位是地址信息，若外接高电平则为1，外接低电平则为0，最低位为读(1)/写(0)信号。

# 操作要求

**CLOCK and DATA TRANSITIONS:** The SDA pin is normally pulled high with an external device. Data on the SDA pin may change only during SCL low time periods . Data changes during SCL high periods will indicate a start or stop
condition as defined below.

**START CONDITION:** A high-to-low transition of SDA with SCL high is a start condition which must precede any other command.

**STOP CONDITION:** A low-to-high transition of SDA with SCL high is a stop condition.After a read sequence, the stop command will place the EEPROM in a standby power mode.

**ACKNOWLEDGE:** All addresses and data words are serially transmitted to and from the EEPROM in 8-bit words. The EEPROM sends a zero to acknowledge that it has received each word. This happens during the ninth clock cycle.

**STANDBY MODE:** The AT24C01A/02/04/08A/16A features a low-power standby mode which is enabled: (a) upon power-up and (b) after the receipt of the STOP bit and the completion of any internal operations.

**MEMORY RESET:** After an interruption in protocol, power loss or system reset, any 2-wire part can be reset by following these steps:

> Clock up to 9 cycles.

> Look for SDA high in each cycle while SCL is high.

> Create a start condition.

以上摘自《AT24C01A/02/04/08A/16A》datasheet