# FX5 CPU Middleware Demo

This is a middleware program for Mitsubishi FX5 PLC. It provides the following functionality:

1. Reads data from the PLC every 200ms and displays it in the program.
2. Writes the given input to the PLC.
3. Monitors the PLC connection. If the connection is lost, it displays **Connection Lost** in red; when reconnected, it displays **Connected** in green.

---

## Requirements

- **.NET Framework:** 4.6.1  
- **Platform:** 64-bit CPU  
- **External Library:** COM Library (`ActUtlType64Lib`)

---

## Examples

### Reading Data from PLC

<img src="FX5_demo_middleware/FX5_demo_middleware/images/1.png" alt="PLC Data Reading" />

Above, you can see the program reading and displaying PLC values in real time.

---

### Writing Data to PLC

<img src="FX5_demo_middleware/FX5_demo_middleware/images/2.png" alt="Writing to PLC" />

Above, you can see the program writing a given value to the PLC.

---

### Connection Lost

<img src="FX5_demo_middleware/FX5_demo_middleware/images/3.png" alt="Connection Lost" />

Above, the program shows the **Connection Lost** state in red when the PLC connection is interrupted.

---

### Reconnection

<img src="FX5_demo_middleware/FX5_demo_middleware/images/4.png" alt="Reconnected" />

Above, the program reconnects to the PLC within seconds and displays **Connected** in green.
