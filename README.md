# Compass-GPS

TASK: Object-oriented design of fitting dll
The Fitting software "Compass GPS" is a tool the Hearing Care Professionals use to customize hearing aids
to meet the hearing-impaired clients’ needs.
Programs in general.
The hearing aid can be set up to hold a number of programs, which can be selected by the client (via push
button), depending on the listening needs. The user can for example select a "music program" when the
user needs to listen to music.
Programs can created by the hearing care professional from the user interface in Compass GPS.
Features in general.
A program is customized by tweaking the settings of a number of features in the hearing aid.
A feature can for example be noise reduction. This feature is implemented as a digital signal-processing
algorithm on the chip. In general, how a specific feature is working in the chip, is handled by modifying a
wide range of parameters in an EEPROM.
Compressor feature and rationales.
The primary issue described in this task relates to the feature "compressor". This feature is the non-linear
amplifier that compensates the client's hearing loss.
There are a number of compressors on the chip in the hearing aid that can be set up independently, using
separate set of EEPROM parameters. To a specific program, you might assign one of these compressors.
The chips does not have enough “compressors”, to be able to assign one to every program. This means that
some programs need to share “compressors”.
Each compressor uses a set of parameters, which relates to the client's hearing loss. In addition, there are
various formulas (rationales) to do the calculation of these parameters from clients hearing loss.
Let us assume that we have 3 different formulas, but that might need to be extended in the future.
From the user interface, you can select which formula to be used in a specific program.
Task: Object-oriented design of fitting dll
The responsibility of the Fitting dll is to calculate how the compressor is to be set up in a certain program.
When a program is created from the user interface then it is the fitting dll’s responsibility to calculate the
relevant compressor parameters. These are subsequently written by Compass to the hearing aid.
Based on the above information, we want a proposal of an object-oriented design, for example in the form
of a class diagram. The design shall support creation of a program, including the selection of rationale.
The design shall support future expansions in the direction of more programs, compressors and rationales.
