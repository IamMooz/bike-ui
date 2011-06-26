#pragma once
#include "native.h"

#pragma managed

using namespace System::Collections::Generic;

namespace BikeApi {
	public ref class Case {
		nvCase *nativeObject;
		
	public:
		Case() {
			nativeObject = new nvCase();
		}

		property int Test {
			int get() {
				return nativeObject->test;
			}
		}

		property IList<Case ^> ^ chars {
			IList<Case ^> ^ get() {
				List<Case ^> cases;
				cases.Add(gcnew Case());
				return %cases;
			}
		}
	};
};