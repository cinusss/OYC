import {Text, TouchableOpacity, View} from 'react-native';
import React from 'react';
import {CalendarDay} from '../models/calendar/calendarDay';
import {setActiveDay} from '../slices/calendarSlice';
import {useDispatch} from 'react-redux';

interface HorizonalCalendarDayProps {
  dietDay: CalendarDay;
  isActiveDay: boolean;
}

const HorizonalCalendarDay: React.FC<HorizonalCalendarDayProps> = ({
  dietDay,
  isActiveDay,
}) => {
  const dispatch = useDispatch();
  const setActiveDayState = (dietDayId: number) => {
    dispatch(setActiveDay(dietDayId));
  };

  return (
    <TouchableOpacity
      onPress={() => {
        setActiveDayState(dietDay.dietDayId);
      }}
      className={
        !isActiveDay
          ? 'pb-3 items-center mx-6 space-x-2 mb-2'
          : 'rounded-md items-center mx-6 space-x-2 bg-teal-500 pb-3 mb-2 scale-125'
      }>
      <View>
        <Text className="font-bold text-base">
          {dietDay?.day.split(' ')[0]}
        </Text>
      </View>
      <View>
        <Text>{dietDay?.day.split(' ')[1].slice(0, 5)}</Text>
      </View>
    </TouchableOpacity>
  );
};

export default HorizonalCalendarDay;
