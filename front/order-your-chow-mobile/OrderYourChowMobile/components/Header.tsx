import {View, Text, TouchableOpacity} from 'react-native';
import React from 'react';

interface HeaderProps {
  title: string;
  backArrow?: boolean;
}

const Header: React.FC<HeaderProps> = ({title, backArrow}) => {
  return (
    <View className="relative">
      {backArrow && (
        <TouchableOpacity className="absolute top-14 left-5 p-2 bg-teal-500"></TouchableOpacity>
      )}
      <Text className="font-bold text-xl bg-white py-3 border-gray-400 border-b-2 border-dotted border-spacing-2 text-center">
        {title}
      </Text>
    </View>
  );
};

export default Header;
